//using OpenQA.Selenium;
//using OpenQA.Selenium.Support.UI;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _30DaysAutomationChallenge.POM
//{
//    public abstract class LoadableComponent<T> : ILoadableComponent
//        where T : LoadableComponent<T>
//    {

//        protected bool IsLoaded
//        {
//            get
//            {
//                bool isLoaded = false;
//                try
//                {
//                    isLoaded = this.EvaluateLoadedStatus();
//                }
//                catch (WebDriverException)
//                {
//                    return false;
//                }

//                return isLoaded;
//            }
//        }
//        ILoadableComponent ILoadableComponent.Load()
//        {
//            return (ILoadableComponent)this.Load();
//        }
//        public virtual T Load()
//        {
//            if (this.IsLoaded)
//            {
//                return (T)this;
//            }
//            else
//            {
//                this.TryLoad();
//            }

//             return (T)this;
//        }

//        protected abstract void ExecuteLoad();

//        protected abstract bool EvaluateLoadedStatus();

//        protected T TryLoad()
//        {
//            try
//            {
//                this.ExecuteLoad();
//            }
//            catch (WebDriverException e)
//            {
//                throw(e);
//            }

//            return (T)this;
//        }


//    }
//}
