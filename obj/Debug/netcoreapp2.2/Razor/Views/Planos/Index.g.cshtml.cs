#pragma checksum "C:\Users\Family\Documents\Gabriel Rodrigues Amador\SENAI\PROJETOS\WebMVC-Projetos\AgoraVai PontoDigital\Views\Planos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ba7a604895b7f2991283ae322cd12007d9d4db2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Planos_Index), @"mvc.1.0.view", @"/Views/Planos/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Planos/Index.cshtml", typeof(AspNetCore.Views_Planos_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Family\Documents\Gabriel Rodrigues Amador\SENAI\PROJETOS\WebMVC-Projetos\AgoraVai PontoDigital\Views\Planos\Index.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#line 2 "C:\Users\Family\Documents\Gabriel Rodrigues Amador\SENAI\PROJETOS\WebMVC-Projetos\AgoraVai PontoDigital\Views\Planos\Index.cshtml"
using System.IO;

#line default
#line hidden
#line 3 "C:\Users\Family\Documents\Gabriel Rodrigues Amador\SENAI\PROJETOS\WebMVC-Projetos\AgoraVai PontoDigital\Views\Planos\Index.cshtml"
using AgoraVai_PontoDigital.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ba7a604895b7f2991283ae322cd12007d9d4db2", @"/Views/Planos/Index.cshtml")]
    public class Views_Planos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\Family\Documents\Gabriel Rodrigues Amador\SENAI\PROJETOS\WebMVC-Projetos\AgoraVai PontoDigital\Views\Planos\Index.cshtml"
  
Layout = "_Layout";
var listaFormas = (List<FormaPagamento>) ViewData["listaPlanos"];
    var userEmail = (string) ViewData["UserLogado"];
  
    

#line default
#line hidden
            BeginContext(250, 14, true);
            WriteLiteral("    <header>\r\n");
            EndContext();
#line 11 "C:\Users\Family\Documents\Gabriel Rodrigues Amador\SENAI\PROJETOS\WebMVC-Projetos\AgoraVai PontoDigital\Views\Planos\Index.cshtml"
          
        Html.RenderPartial("_HeaderNavBar");
        

#line default
#line hidden
            BeginContext(333, 996, true);
            WriteLiteral(@"    </header>
    <main>
        <section id=""section_master_planos"">

            <section id=""area_planos"">
                <div>
                    <h2 class=""h2"">Planos</h2>
                </div>

                <div id=""area_boxs_planos"" class=""margin-left"">
                    <div class=""stylePlan_2"">
                        <!--PLANO médio  2-->
                        <div>
                            <h4 class=""h4"">Com até 5 funcionários</h3>

                                <p class=""p_planos"">
                                    - Pagamento Mensal
                                    <br />
                                    - Suporte de até 24 horas
                                    <br />
                                    - Recomendação para empresas de pequeno porte
                                </p>

                                <p class=""preço_planos"">R$ 29,90</p>

                                <form class=""form"" method=""POST""");
            EndContext();
            BeginWriteAttribute("action", " action=\'", 1329, "\'", 1369, 1);
#line 39 "C:\Users\Family\Documents\Gabriel Rodrigues Amador\SENAI\PROJETOS\WebMVC-Projetos\AgoraVai PontoDigital\Views\Planos\Index.cshtml"
WriteAttributeValue("", 1338, Url.Action("Comprar","Planos"), 1338, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1370, 196, true);
            WriteLiteral(">\r\n\r\n                                    <select id=\"select\" name=\"formaP\" required>\r\n\r\n                                        <option value=\"\" disabled selected> Formas de pagamento: </option>\r\n");
            EndContext();
#line 44 "C:\Users\Family\Documents\Gabriel Rodrigues Amador\SENAI\PROJETOS\WebMVC-Projetos\AgoraVai PontoDigital\Views\Planos\Index.cshtml"
                                         foreach(var item in listaFormas){

#line default
#line hidden
            BeginContext(1642, 47, true);
            WriteLiteral("                                        <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1689, "\"", 1719, 1);
#line 45 "C:\Users\Family\Documents\Gabriel Rodrigues Amador\SENAI\PROJETOS\WebMVC-Projetos\AgoraVai PontoDigital\Views\Planos\Index.cshtml"
WriteAttributeValue("", 1697, item.FormaDePagamento, 1697, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1720, 2, true);
            WriteLiteral("> ");
            EndContext();
            BeginContext(1723, 21, false);
#line 45 "C:\Users\Family\Documents\Gabriel Rodrigues Amador\SENAI\PROJETOS\WebMVC-Projetos\AgoraVai PontoDigital\Views\Planos\Index.cshtml"
                                                                           Write(item.FormaDePagamento);

#line default
#line hidden
            EndContext();
            BeginContext(1744, 12, true);
            WriteLiteral(" </option>\r\n");
            EndContext();
#line 46 "C:\Users\Family\Documents\Gabriel Rodrigues Amador\SENAI\PROJETOS\WebMVC-Projetos\AgoraVai PontoDigital\Views\Planos\Index.cshtml"
                                        }

#line default
#line hidden
            BeginContext(1799, 912, true);
            WriteLiteral(@"                                    </select>

                                    <input id=""btn_compre"" type=""submit"" name=""preco"" value=""Compre-já"">

                                </form>
                        </div>
                    </div>
                    <!--PAGINA MUTÁVEL-->
                    <div class=""stylePlan"">
                        <!--PLANO médio 1-->
                        <h4 class=""h4"">Com até 50 Funcionários</h4>

                        <p class=""p_planos"">
                            - Pagamento Mensal
                            <br />
                            - Suporte de até 12 horas
                            <br />
                            - Recomendação para empresas de pequeno porte
                        </p>

                        <p class=""preço_planos"">R$ 149,90</p>

                        <form class=""form"" method=""POST""");
            EndContext();
            BeginWriteAttribute("action", " action=\'", 2711, "\'", 2751, 1);
#line 69 "C:\Users\Family\Documents\Gabriel Rodrigues Amador\SENAI\PROJETOS\WebMVC-Projetos\AgoraVai PontoDigital\Views\Planos\Index.cshtml"
WriteAttributeValue("", 2720, Url.Action("Comprar","Planos"), 2720, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2752, 176, true);
            WriteLiteral(">\r\n                            <select id=\"select\" name=\"formaP\" required>\r\n                                <option value=\"\" disabled selected> Formas de pagamento: </option>\r\n");
            EndContext();
#line 72 "C:\Users\Family\Documents\Gabriel Rodrigues Amador\SENAI\PROJETOS\WebMVC-Projetos\AgoraVai PontoDigital\Views\Planos\Index.cshtml"
                                 foreach(var item in listaFormas){

#line default
#line hidden
            BeginContext(2996, 39, true);
            WriteLiteral("                                <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3035, "\"", 3065, 1);
#line 73 "C:\Users\Family\Documents\Gabriel Rodrigues Amador\SENAI\PROJETOS\WebMVC-Projetos\AgoraVai PontoDigital\Views\Planos\Index.cshtml"
WriteAttributeValue("", 3043, item.FormaDePagamento, 3043, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3066, 2, true);
            WriteLiteral("> ");
            EndContext();
            BeginContext(3069, 21, false);
#line 73 "C:\Users\Family\Documents\Gabriel Rodrigues Amador\SENAI\PROJETOS\WebMVC-Projetos\AgoraVai PontoDigital\Views\Planos\Index.cshtml"
                                                                   Write(item.FormaDePagamento);

#line default
#line hidden
            EndContext();
            BeginContext(3090, 12, true);
            WriteLiteral(" </option>\r\n");
            EndContext();
#line 74 "C:\Users\Family\Documents\Gabriel Rodrigues Amador\SENAI\PROJETOS\WebMVC-Projetos\AgoraVai PontoDigital\Views\Planos\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(3137, 2022, true);
            WriteLiteral(@"                            </select>
                            <!-- <select id=""select"" name=""Formas de pagamento"" required>
                            <option value="""" disabled selected> Formas de pagamento: </option>
                            <option value=""Cartão de crédito""> Cartão de Crédito </option>
                            <option value=""Boleto Bancário""> Boleto Bancário </option>
                            <option value=""Débito Automático (débito em conta, débito online)""> Débito Automático
                                (débito em conta, débito online)</option>
                            <option value=""Pagamentos Digitais""> Pagamentos Digitais </option>
                            <option value=""Transferência bancária ""> Transferência bancária </option>
                            <option value=""Dinheiro""> Dinheiro </option>
                            <option value=""Cheques""> Cheques </option>
                        </select> -->
                            <input id=""btn_c");
            WriteLiteral(@"ompre"" type=""submit"" name=""preco"" value=""Compre-já "">

                        </form>
                    </div>
                </div>

                <div id=""area_boxs_planos"">


                    <div class=""stylePlan"">
                        <!--PAGINA MUTÁVEL-->
                        <!--NONE-->

                        <div>
                            <!--PLANO Grande-->
                            <h4 class=""h4"">Com até 500 funcionários</h3>

                                <p class=""p_planos"">
                                    - Pagamento Mensal
                                    <br />
                                    - Suporte de até 2 horas
                                    <br />
                                    - Recomendação para empresas de médio porte
                                </p>

                                <p class=""preço_planos"">R$ 299,90</p>

                                <form class=""form"" method=""POST""");
            EndContext();
            BeginWriteAttribute("action", " action=\'", 5159, "\'", 5199, 1);
#line 114 "C:\Users\Family\Documents\Gabriel Rodrigues Amador\SENAI\PROJETOS\WebMVC-Projetos\AgoraVai PontoDigital\Views\Planos\Index.cshtml"
WriteAttributeValue("", 5168, Url.Action("Comprar","Planos"), 5168, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5200, 192, true);
            WriteLiteral(">\r\n                                    <select id=\"select\" name=\"formaP\" required>\r\n                                        <option value=\"\" disabled selected> Formas de pagamento: </option>\r\n");
            EndContext();
#line 117 "C:\Users\Family\Documents\Gabriel Rodrigues Amador\SENAI\PROJETOS\WebMVC-Projetos\AgoraVai PontoDigital\Views\Planos\Index.cshtml"
                                         foreach(var item in listaFormas){

#line default
#line hidden
            BeginContext(5468, 47, true);
            WriteLiteral("                                        <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 5515, "\"", 5545, 1);
#line 118 "C:\Users\Family\Documents\Gabriel Rodrigues Amador\SENAI\PROJETOS\WebMVC-Projetos\AgoraVai PontoDigital\Views\Planos\Index.cshtml"
WriteAttributeValue("", 5523, item.FormaDePagamento, 5523, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5546, 2, true);
            WriteLiteral("> ");
            EndContext();
            BeginContext(5549, 21, false);
#line 118 "C:\Users\Family\Documents\Gabriel Rodrigues Amador\SENAI\PROJETOS\WebMVC-Projetos\AgoraVai PontoDigital\Views\Planos\Index.cshtml"
                                                                           Write(item.FormaDePagamento);

#line default
#line hidden
            EndContext();
            BeginContext(5570, 12, true);
            WriteLiteral(" </option>\r\n");
            EndContext();
#line 119 "C:\Users\Family\Documents\Gabriel Rodrigues Amador\SENAI\PROJETOS\WebMVC-Projetos\AgoraVai PontoDigital\Views\Planos\Index.cshtml"
                                        }

#line default
#line hidden
            BeginContext(5625, 1071, true);
            WriteLiteral(@"                                    </select>
                                    <input id=""btn_compre"" type=""submit"" name=""preco"" value=""Compre-já  "">

                                </form>
                        </div>

                    </div>

                    <div class=""stylePlan"">
                        <!--PAGINA MUTÁVEL-->
                        <!--NONE-->

                        <div>
                            <!--PLANO Pequeno-->
                            <h4 class=""h4"">Acima de 500 funcionários</h3>

                                <p class=""p_planos"">
                                    - Pagamento Mensal
                                    <br />
                                    - Suporte de até 1 hora
                                    <br />
                                    - Recomendação para empresas de grande porte
                                </p>

                                <p class=""preço_planos"">A definir..</p>

                 ");
            WriteLiteral("               <form class=\"form\" method=\"POST\"");
            EndContext();
            BeginWriteAttribute("action", " action=\'", 6696, "\'", 6736, 1);
#line 146 "C:\Users\Family\Documents\Gabriel Rodrigues Amador\SENAI\PROJETOS\WebMVC-Projetos\AgoraVai PontoDigital\Views\Planos\Index.cshtml"
WriteAttributeValue("", 6705, Url.Action("Comprar","Planos"), 6705, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6737, 192, true);
            WriteLiteral(">\r\n                                    <select id=\"select\" name=\"formaP\" required>\r\n                                        <option value=\"\" disabled selected> Formas de pagamento: </option>\r\n");
            EndContext();
#line 149 "C:\Users\Family\Documents\Gabriel Rodrigues Amador\SENAI\PROJETOS\WebMVC-Projetos\AgoraVai PontoDigital\Views\Planos\Index.cshtml"
                                         foreach(var item in listaFormas){

#line default
#line hidden
            BeginContext(7005, 47, true);
            WriteLiteral("                                        <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 7052, "\"", 7082, 1);
#line 150 "C:\Users\Family\Documents\Gabriel Rodrigues Amador\SENAI\PROJETOS\WebMVC-Projetos\AgoraVai PontoDigital\Views\Planos\Index.cshtml"
WriteAttributeValue("", 7060, item.FormaDePagamento, 7060, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7083, 2, true);
            WriteLiteral("> ");
            EndContext();
            BeginContext(7086, 21, false);
#line 150 "C:\Users\Family\Documents\Gabriel Rodrigues Amador\SENAI\PROJETOS\WebMVC-Projetos\AgoraVai PontoDigital\Views\Planos\Index.cshtml"
                                                                           Write(item.FormaDePagamento);

#line default
#line hidden
            EndContext();
            BeginContext(7107, 12, true);
            WriteLiteral(" </option>\r\n");
            EndContext();
#line 151 "C:\Users\Family\Documents\Gabriel Rodrigues Amador\SENAI\PROJETOS\WebMVC-Projetos\AgoraVai PontoDigital\Views\Planos\Index.cshtml"
                                        }

#line default
#line hidden
            BeginContext(7162, 3889, true);
            WriteLiteral(@"                                    </select>
                                    <input id=""btn_compre"" type=""submit"" name=""preco""
                                        value=""Compre-já   "">
                                </form>
                        </div>
                    </div>
                </div>
            </section>

        </section>

        <section id=""area_qualidade"">

            <div class=""video"">
                <!--INSERIR O PROPRIO VIDEO DO YUTUBE NA HTML-->
                <iframe width=""90%"" height=""415"" src=""https://www.youtube.com/embed/Pgc_lzXmxtY"" frameborder=""0""
                    allow=""accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture""
                    allowfullscreen></iframe>
            </div>
            <div class=""cont_video"">
                <div>

                    <h2 class=""h2_qualidade""> Qualidade!</h2>
                    <p class=""p_qualidade"">
                        Lorem ipsum dolor sit amet consectetu");
            WriteLiteral(@"r adipisicing elit. Velit quis molestias minus hic,
                        architecto
                        rem voluptas dolore accusamus repellat adipisci tempore quibusdam, itaque mollitia quia commodi
                        expedita ea ipsam minima.Lorem ipsum dolor sit amet consectetur adipisicing elit. Velit quis
                        molestias minus hic, architecto
                        rem voluptas dolore accusamus repellat adipisci tempore quibusdam, itaque mollitia quia commodi
                        expedita ea ipsam minima.Lorem ipsum dolor sit amet consectetur adipisicing elit. Velit quis
                        molestias minus hic, architecto
                        rem voluptas dolore accusamus repellat adipisci tempore quibusdam, itaque mollitia quia commodi
                        expedita ea ipsam minima.Lorem ipsum dolor sit amet consectetur adipisicing elit. Velit quis
                        molestias minus hic, architecto
                        rem voluptas dolore acc");
            WriteLiteral(@"usamus repellat adipisci tempore quibusdam, itaque mollitia quia commodi
                        expedita ea ipsam minima.Lorem ipsum dolor sit amet consectetur adipisicing elit. Velit quis
                        molestias minus hic, architecto
                    </p>
                </div>
            </div>
        </section>

        <section id=""area_gratuidade"">

            <section class=""cont_gratuito"">
                <div>

                    <h2 class=""h2_gratuito"">30 dias gratuitos!</h2>

                    <p class=""p_qualidade_2"" >
                        Lorem ipsum dolor sit amet consectetur adipisicing elit. Mollitia eius sint repellendus commodi
                        nostrum quidem voluptatum rerum consectetur iste architecto accusantium nemo, praesentium
                        numquam ea
                        alias! Quos earum molestias nesciunt?
                        Lorem ipsum dolor sit, amet consectetur adipisicing elit. Cum eaque animi in iure. Repellendu");
            WriteLiteral(@"s
                        omnis
                        vitae fuga! Facilis cupiditate dicta accusamus? Alias cumque est consequuntur sunt vel iusto,
                        quis
                        quaerat!
                        Lorem ipsum dolor sit amet consectetur adipisicing elit. Mollitia eius sint repellendus commodi
                        nostrum quidem voluptatum rerum consectetur iste architecto accusantium nemo, praesentium
                        numquam ea
                        alias! Quos earum molestias nesciunt?
                        Lorem ipsum dolor sit, amet consectetur adipisicing elit. Cum eaque animi in iure. Repellendus
                        omnis
                        vitae fuga!
                    </p>

                    <form id=""form"" method=""POST""");
            EndContext();
            BeginWriteAttribute("action", " action=\'", 11051, "\'", 11098, 1);
#line 221 "C:\Users\Family\Documents\Gabriel Rodrigues Amador\SENAI\PROJETOS\WebMVC-Projetos\AgoraVai PontoDigital\Views\Planos\Index.cshtml"
WriteAttributeValue("", 11060, Url.Action("EnviarSoftware","Planos"), 11060, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(11099, 569, true);
            WriteLiteral(@">
                        <input id=""textarea_gratuito"" type=""email"" name=""email""
                            placeholder=""Digite seu e-mail para o teste de 30 dias gratuitos"">
                        <input id=""btn_enviar_gratuito"" type=""submit"" value=""Enviar"">

                    </form>
                </div>
            </section>

            <article class=""img_gratuito"">
                <img src=""Imagens/dias_gratuitos.png"" alt=""Imagem Meramente Ilustrativa"" height=""400px"">
            </article>
        </section>


        

    </main>");
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
