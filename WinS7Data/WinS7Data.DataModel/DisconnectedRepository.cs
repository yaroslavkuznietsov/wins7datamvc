using WinS7Data.DataLibrary.Models;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using static WinS7Data.DataModel.DeserializerForMvc;

namespace WinS7Data.DataModel
{
    public class DisconnectedRepository
    {
        /// <summary>
        /// Glass
        /// </summary>
        /// <param name="query"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Recipe> GetQueryableGlassWithOrderCustomer(string query, int page, int pageSize)
        {
            using (var context = new RecipeContext())
            {
                context.Database.Log = message => Debug.WriteLine(message);
                var linqQuery = context.Recipes.Include(r => r.DatHE);     //.Include(g => g.Customer)
                if (!string.IsNullOrEmpty(query))
                {
                    linqQuery = linqQuery.Where(g => g.ToolName.Contains(query));
                }
                if (page > 0 && pageSize > 0)
                {
                    linqQuery = linqQuery.OrderBy(n => n.ToolName).Skip(page - 1).Take(pageSize);
                }

                return linqQuery.ToList();
            }
        }


        //public List<Glass> GetGlassesWithOrder()
        //{
        //    using (var context = new GlassContext())
        //    {
        //        //return context.GlassSet.Include(g => g.Customer).Include(g => g.Order).ToList();
        //        return context.GlassSet.AsNoTracking()
        //            .Include(g => g.Order).ToList();
        //    }
        //}

        ////public List<Glass> GetGlassesWithCustomer()
        ////{
        ////    using (var context = new GlassContext())
        ////    {
        ////        //return context.GlassSet.Include(g => g.Customer).Include(g => g.Order).ToList();
        ////        return context.GlassSet.AsNoTracking()
        ////            .Include(g => g.Customer).ToList();
        ////    }
        ////}

        ////public List<Glass> GetGlassesWithOrderCustomer()
        ////{
        ////    using (var context = new GlassContext())
        ////    {
        ////        //return context.GlassSet.Include(g => g.Customer).Include(g => g.Order).ToList();
        ////        return context.GlassSet.AsNoTracking()
        ////            .Include(g => g.Customer)
        ////            .Include(g => g.Order).ToList();
        ////    }
        ////}


        //public Glass GetGlassWithOrder(int id)
        //{
        //    using (var context = new GlassContext())
        //    {
        //        return context.GlassSet.AsNoTracking()
        //            .Include(g => g.Order)
        //            .FirstOrDefault(g => g.Id == id);       //.Include(g => g.Customer)
        //    }
        //}


        //public Glass GetGlassById(int id)
        //{
        //    using (var context = new GlassContext())
        //    {
        //        return context.GlassSet.Find(id);
        //        // return context.GlassSet.AsNoTracking().SingleOrDefault(g => g.Id == id);
        //    }
        //}

        //public void SaveUpdatedGlass(Glass glass)
        //{
        //    using (var context = new GlassContext())
        //    {
        //        context.Entry(glass).State = EntityState.Modified;
        //        context.SaveChanges();
        //    }
        //}

        List<Recipe> recipes = new List<Recipe>();
        List<DatHE> hes = new List<DatHE>();
        List<DatConfig> configs = new List<DatConfig>();
        List<DatN2> n2s = new List<DatN2>();
        List<DatWerkzeug> werkzeugs = new List<DatWerkzeug>();
        List<DatMWerkzeug> mwerkzeugs = new List<DatMWerkzeug>();

        public List<DatHE> GetAllDatHEs()
        {
            GetAllRecipes();
            return hes;
        }

        public List<DatConfig> GetAllDatConfigs()
        {
            GetAllRecipes();
            return configs;
        }
        public List<DatN2> GetAllDatN2s()
        {
            GetAllRecipes();
            return n2s;
        }

        public List<DatWerkzeug> GetAllDatWerkzeugs()
        {
            GetAllRecipes();
            return werkzeugs;
        }


        public void GetAllRecipes()
        {
            recipes = GetRecipesFromFolder();

            foreach (var recipe in recipes)
            {
                hes.Add(recipe.DatHE);
                configs.Add(recipe.DatConfig);
                n2s.Add(recipe.DatN2);
                werkzeugs.Add(recipe.DatWerkzeug);
                foreach (var mwerkzeug in recipe.DatMWerkzeugs)
                {
                    mwerkzeugs.Add(mwerkzeug);
                }

            }
        }

        public void SaveNewRecipe(Recipe recipe)
        {
            using (var context = new RecipeContext())
            {
                context.Recipes.Add(recipe);
                context.SaveChanges();
            }
        }

        public void SaveRecipes(List<Recipe> recipes)
        {
            for (int i = 1; i < 127; i++)
            {
                foreach (var recipe in recipes)
                {
                    if (recipe.ToolCode == i)
                    {
                        using (var context = new RecipeContext())
                        {
                            context.Recipes.Add(recipe);
                            context.SaveChanges();
                        } 
                    }
                }
            }

            
        }

        //public void DeleteGlass(int glassId)
        //{
        //    using (var context = new GlassContext())
        //    {
        //        var glass = context.GlassSet.Find(glassId);
        //        context.Entry(glass).State = EntityState.Deleted;
        //        context.SaveChanges();
        //    }
        //}



        //public IEnumerable GetCustomerList()
        //{
        //    using (var context = new GlassContext())
        //    {
        //        return context.CustomerSet.AsNoTracking()
        //            .OrderBy(c => c.Name)
        //            .Select(c => new { c.Id, c.Name }).ToList();  //, c.Address, c.Phone, c.OrdersList, c.GlassesList
        //    }
        //}

        //public IEnumerable GetOrderList()
        //{
        //    using (var context = new GlassContext())
        //    {
        //        return context.OrderSet.AsNoTracking()
        //            .OrderBy(o => o.Number)
        //            .Select(o => new { o.Id, o.Number }).ToList();    //, o.DateTime, o.Customer, o.CustomerId
        //    }
        //}



    }
}
