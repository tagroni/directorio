#pragma checksum "c:\Users\tagiv\OneDrive\Escritorio\proyectos visual code\Directorio\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf29b346713731cb87bb70c683fdd3aee7253109"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf29b346713731cb87bb70c683fdd3aee7253109", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("page-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 34, true);
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n\n");
            EndContext();
            BeginContext(34, 811, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf29b346713731cb87bb70c683fdd3aee72531093256", async() => {
                BeginContext(40, 798, true);
                WriteLiteral(@"

  <meta charset=""utf-8"">
  <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
  <meta name=""description"" content="""">
  <meta name=""author"" content="""">

  <title>Grayscale - Start Bootstrap Theme</title>

  <!-- Bootstrap core CSS -->
  <link href=""../vendor/bootstrap/css/bootstrap.min.css"" rel=""stylesheet"">

  <!-- Custom fonts for this template -->
  <link href=""../vendor/fontawesome-free/css/all.min.css"" rel=""stylesheet"">
  <link href=""../https://fonts.googleapis.com/css?family=Varela+Round"" rel=""stylesheet"">
  <link href=""https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i"" rel=""stylesheet"">

  <!-- Custom styles for this template -->
  <link href=""css/grayscale.min.css"" rel=""stylesheet"">

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(845, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            BeginContext(847, 7565, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf29b346713731cb87bb70c683fdd3aee72531095268", async() => {
                BeginContext(867, 7538, true);
                WriteLiteral(@"

  <!-- Navigation -->
  <nav class=""navbar navbar-expand-lg navbar-light fixed-top"" id=""mainNav"">
    <div class=""container"">
      <a class=""navbar-brand js-scroll-trigger"" href=""#page-top"">Start Bootstrap</a>
      <button class=""navbar-toggler navbar-toggler-right"" type=""button"" data-toggle=""collapse"" data-target=""#navbarResponsive"" aria-controls=""navbarResponsive"" aria-expanded=""false"" aria-label=""Toggle navigation"">
        Menu
        <i class=""fas fa-bars""></i>
      </button>
      <div class=""collapse navbar-collapse"" id=""navbarResponsive"">
        <ul class=""navbar-nav ml-auto"">
          <li class=""nav-item"">
            <a class=""nav-link js-scroll-trigger"" href=""#about"">About</a>
          </li>
          <li class=""nav-item"">
            <a class=""nav-link js-scroll-trigger"" href=""#projects"">Projects</a>
          </li>
          <li class=""nav-item"">
            <a class=""nav-link js-scroll-trigger"" href=""#signup"">Contact</a>
          </li>
        </ul>
      </div>
    </div>
  </nav>

  ");
                WriteLiteral(@"<!-- Header -->
  <header class=""masthead"">
    <div class=""container d-flex h-100 align-items-center"">
      <div class=""mx-auto text-center"">
        <h1 class=""mx-auto my-0 text-uppercase"">Grayscale</h1>
        <h2 class=""text-white-50 mx-auto mt-2 mb-5"">A free, responsive, one page Bootstrap theme created by Start Bootstrap.</h2>
        <a href=""#about"" class=""btn btn-primary js-scroll-trigger"">Get Started</a>
      </div>
    </div>
  </header>

  <!-- About Section -->
  <section id=""about"" class=""about-section text-center"">
    <div class=""container"">
      <div class=""row"">
        <div class=""col-lg-8 mx-auto"">
          <h2 class=""text-white mb-4"">Built with Bootstrap 4</h2>
          <p class=""text-white-50"">Grayscale is a free Bootstrap theme created by Start Bootstrap. It can be yours right now, simply download the template on
            <a href=""http://startbootstrap.com/template-overviews/grayscale/"">the preview page</a>. The theme is open source, and you can use it for any purpose, personal");
                WriteLiteral(@" or commercial.</p>
        </div>
      </div>
      <img src=""img/ipad.png"" class=""img-fluid"" alt="""">
    </div>
  </section>

  <!-- Projects Section -->
  <section id=""projects"" class=""projects-section bg-light"">
    <div class=""container"">

      <!-- Featured Project Row -->
      <div class=""row align-items-center no-gutters mb-4 mb-lg-5"">
        <div class=""col-xl-8 col-lg-7"">
          <img class=""img-fluid mb-3 mb-lg-0"" src=""img/bg-masthead.jpg"" alt="""">
        </div>
        <div class=""col-xl-4 col-lg-5"">
          <div class=""featured-text text-center text-lg-left"">
            <h4>Shoreline</h4>
            <p class=""text-black-50 mb-0"">Grayscale is open source and MIT licensed. This means you can use it for any project - even commercial projects! Download it, customize it, and publish your website!</p>
          </div>
        </div>
      </div>

      <!-- Project One Row -->
      <div class=""row justify-content-center no-gutters mb-5 mb-lg-0"">
        <div class=""col-lg-6"">
          <img ");
                WriteLiteral(@"class=""img-fluid"" src=""img/demo-image-01.jpg"" alt="""">
        </div>
        <div class=""col-lg-6"">
          <div class=""bg-black text-center h-100 project"">
            <div class=""d-flex h-100"">
              <div class=""project-text w-100 my-auto text-center text-lg-left"">
                <h4 class=""text-white"">Misty</h4>
                <p class=""mb-0 text-white-50"">An example of where you can put an image of a project, or anything else, along with a description.</p>
                <hr class=""d-none d-lg-block mb-0 ml-0"">
              </div>
            </div>
          </div>
        </div>
      </div>

      <!-- Project Two Row -->
      <div class=""row justify-content-center no-gutters"">
        <div class=""col-lg-6"">
          <img class=""img-fluid"" src=""img/demo-image-02.jpg"" alt="""">
        </div>
        <div class=""col-lg-6 order-lg-first"">
          <div class=""bg-black text-center h-100 project"">
            <div class=""d-flex h-100"">
              <div class=""project-text w-100 my-auto tex");
                WriteLiteral(@"t-center text-lg-right"">
                <h4 class=""text-white"">Mountains</h4>
                <p class=""mb-0 text-white-50"">Another example of a project with its respective description. These sections work well responsively as well, try this theme on a small screen!</p>
                <hr class=""d-none d-lg-block mb-0 mr-0"">
              </div>
            </div>
          </div>
        </div>
      </div>

    </div>
  </section>

  <!-- Signup Section -->
  <section id=""signup"" class=""signup-section"">
    <div class=""container"">
      <div class=""row"">
        <div class=""col-md-10 col-lg-8 mx-auto text-center"">

          <i class=""far fa-paper-plane fa-2x mb-2 text-white""></i>
          <h2 class=""text-white mb-5"">Subscribe to receive updates!</h2>

          <form class=""form-inline d-flex"">
            <input type=""email"" class=""form-control flex-fill mr-0 mr-sm-2 mb-3 mb-sm-0"" id=""inputEmail"" placeholder=""Enter email address..."">
            <button type=""submit"" class=""btn btn-primary mx-auto"">Sub");
                WriteLiteral(@"scribe</button>
          </form>

        </div>
      </div>
    </div>
  </section>

  <!-- Contact Section -->
  <section class=""contact-section bg-black"">
    <div class=""container"">

      <div class=""row"">

        <div class=""col-md-4 mb-3 mb-md-0"">
          <div class=""card py-4 h-100"">
            <div class=""card-body text-center"">
              <i class=""fas fa-map-marked-alt text-primary mb-2""></i>
              <h4 class=""text-uppercase m-0"">Address</h4>
              <hr class=""my-4"">
              <div class=""small text-black-50"">4923 Market Street, Orlando FL</div>
            </div>
          </div>
        </div>

        <div class=""col-md-4 mb-3 mb-md-0"">
          <div class=""card py-4 h-100"">
            <div class=""card-body text-center"">
              <i class=""fas fa-envelope text-primary mb-2""></i>
              <h4 class=""text-uppercase m-0"">Email</h4>
              <hr class=""my-4"">
              <div class=""small text-black-50"">
                <a href=""#"">hello@yourdomain.com</");
                WriteLiteral(@"a>
              </div>
            </div>
          </div>
        </div>

        <div class=""col-md-4 mb-3 mb-md-0"">
          <div class=""card py-4 h-100"">
            <div class=""card-body text-center"">
              <i class=""fas fa-mobile-alt text-primary mb-2""></i>
              <h4 class=""text-uppercase m-0"">Phone</h4>
              <hr class=""my-4"">
              <div class=""small text-black-50"">+1 (555) 902-8832</div>
            </div>
          </div>
        </div>
      </div>

      <div class=""social d-flex justify-content-center"">
        <a href=""#"" class=""mx-2"">
          <i class=""fab fa-twitter""></i>
        </a>
        <a href=""#"" class=""mx-2"">
          <i class=""fab fa-facebook-f""></i>
        </a>
        <a href=""#"" class=""mx-2"">
          <i class=""fab fa-github""></i>
        </a>
      </div>

    </div>
  </section>

  <!-- Footer -->
  <footer class=""bg-black small text-center text-white-50"">
    <div class=""container"">
      Copyright &copy; Your Website 2019
    </div>
  </fo");
                WriteLiteral(@"oter>

  <!-- Bootstrap core JavaScript -->
  <script src=""../vendor/jquery/jquery.min.js""></script>
  <script src=""../vendor/bootstrap/js/bootstrap.bundle.min.js""></script>

  <!-- Plugin JavaScript -->
  <script src=""../vendor/jquery-easing/jquery.easing.min.js""></script>

  <!-- Custom scripts for this template -->
  <script src=""../js/grayscale.min.js""></script>

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8412, 10, true);
            WriteLiteral("\n\n</html>\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
