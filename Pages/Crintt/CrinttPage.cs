using System.Text;

namespace eomserver
{
   public class CrinttPage: BasePage
   {
      public CrinttPage(
         string pageName,
         IPageComponents components,
         ISessionManager sessionManager = null
      ) 
      { 
         this.PageName = pageName;
         Components = components;
         SessionManager = sessionManager;
         GenerateTemplate();
      }
   }
}
