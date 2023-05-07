# Programação de Funcionalidades

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="4-Metodologia.md"> Metodologia</a>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="5-Arquitetura da Solução.md"> Arquitetura da Solução</a>

Implementação do sistema descrita por meio dos requisitos funcionais e/ou não funcionais. Deve relacionar os requisitos atendidos com os artefatos criados (código fonte), deverão apresentadas as instruções para acesso e verificação da implementação que deve estar funcional no ambiente de hospedagem.

|ID    | Descrição do Requisito  | Artefato(s) produzido(s) |
|------|-----------------------------------------|----|
|RF-001|O web site deve oferecer ao usuário a possibilidade de cadastro/login no site, onde através da funcionalidade acessa o seu closet.  | index.shtml /RegisterPage.shtml / Privacy.cshtml / homecontroller.cs / RegisterPage.cs | 

Tela Home:

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t8-pmv-ads-2023-1-e3-proj-int-t8-grupo04/blob/main/docs/img/home.jpg

Tela login:

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t8-pmv-ads-2023-1-e3-proj-int-t8-grupo04/blob/main/docs/img/tela_login.jpg

Tela Cadastro:

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t8-pmv-ads-2023-1-e3-proj-int-t8-grupo04/blob/main/docs/img/tela_cadastro.jpg

Código da aplicação:

index.shtml:

@{
    ViewData [ " Título " ] =  " Página inicial " ;
}
< cabeça >
    < script  src = " https://code.jquery.com/jquery-3.6.0.min.js " ></ script >
</ cabeça >

< div  class = " centro de texto "  alinhamento de texto:  centro; >
    < img  src = " ~/imgs/slogam.png "  largura = 250  altura = 150  runat = " servidor "  ; >
    < h1  class = " display-6 " >Seja Bem Vindo(a)!</ h1 >
    < p > </ p >
</div> _ _

< div  class = " form-popup "  id = " meuformulário " >
    < form  action = " /action_page.php "  class = " form-container " >
        < span  class = " close "  onclick = " closeForm() " > & times ; </ span >

        < label  for = " email " >< b >E-mail</ b ></ label >
        < input  type = " text "  placeholder = " Enter Email "  name = " email "  obrigatório >

        < label  for = " psw " >< b >Senha</ b ></ label >
        < input  type = " password "  placeholder = " Enter Password "  name = " psw "  obrigatório >

        < button  type = " submit "  class = " btn " >Entrar</ button >
        < button  type = " button "  id = " registerbtn "  class = " btn register " >Cadastrar</ button >
    </forma> _ _
</div> _ _

scripts @section {
    <script> _ _
        $ ( função () {
            $ ( " #registrobtn " ). clique ( função (){
                janela . localização . href  =  ' @Url.Action("RegisterPage", "Home") ' ;
            });
        });
    </ script >

RegisterPage.shtml:

@model MyClosetWeb . Modelos . Do utilizador

@{
    Layout  =  " ~/Views/Shared/_Layout.cshtml " ;
}

<!DOCTYPE html>

<html> _ _
< cabeça >
    < meta  name = " viewport "  content = " width=device-width " />
    < title >Página de registro</ title >
</ cabeça >
< corpo >

< h4 >Cadastre-se!</ h4 >
< h />
< div  classe = " linha " >
    < div  classe = " col-md-4 " >
        < form  asp-action = " RegisterPage " >
            < div  asp-validation-summary = " ModelOnly "  class = " text-danger " ></ div >
            < div  class = " formulário-grupo " >
                < label  asp-for = " Name "  class = " control-label " >Nome Completo</ label >
                < input  asp-for = " Name "  class = " form-control " />
                < span  asp-validation-for = " Name "  class = " text-danger " ></ span >
            </div> _ _
            < div  class = " formulário-grupo " >
                < label  asp-for = " Email "  class = " control-label " ></ label >
                < input  asp-for = " Email "  class = " form-control " />
                < span  asp-validation-for = " Email "  class = " text-danger " ></ span >
            </div> _ _
            < div  class = " formulário-grupo " >
                < label  asp-for = " Senha "  class = " control-label " >Senha</ label >
                < input  asp-for = " Password "  class = " form-control " />
                < span  asp-validation-for = " Password "  class = " text-danger " ></ span >
            </div> _ _
            < b />
           < div  class = " formulário-grupo " >
                < input  type = " submit "  value = " Registrar "  class = " btn btn-primary " />
            </div> _ _
        </forma> _ _
    </div> _ _
</div> _ _

<div> _ _
    < a  asp-action = " Index " >Retornar a página inicial</ a >
</div> _ _

@section Scripts {
    @{ aguarde  Html . RenderPartialAsync ( " _ValidationScriptsPartial " ); }
}
</ corpo >
</html> _ _

Privacy.cshtml:


@{
    ViewData [ " Title " ] =  " Suporte e Comercial " ;
}
< h1 > @ViewData ["Título"]</ h1 >

< p >Contato de Suporte: suporte @MyClosetWeb.com. </p> _ _
< p >Contato Comercial: comercial @MyClosetWeb.com. </p> _ _


homecontroller.cs:

@@ -0,0 +1,32 @@
﻿usando Microsoft . AspNetCore . Mvc ;
usando MyClosetWeb . Modelos ;
usando Sistema . Diagnósticos ;

namespace MyClosetWeb . controladores
{
     classe  pública HomeController  :  Controlador
    {

        índice IActionResult público ( )
        {
            retornar Visão ( ) ;
        }

        Public IActionResult Privacidade ( )
        {
            retornar Visão ( ) ;
        }

        public ActionResult RegisterPage ( )
        {
            retornar Visão ( ) ;
        }


        [ ResponseCache ( Duração =  0 , Local = ResponseCacheLocation . Nenhum , NoStore =  verdadeiro ) ]
        Erro IActionResult público ( )
        {
            return View ( new ErrorViewModel {  RequestId  = Activity . Current ? . Id ?? HttpContext . TraceIdentifier } ) ;
        }
    }
}


RegisterPage.cs:

@@ -0,0 +1,83 @@
﻿usando Microsoft . AspNetCore . Http ;
usando Microsoft . AspNetCore . Mvc ;

namespace MyClosetWeb . controladores
{
     classe  pública RegisterPageController  :  Controlador
    {
        // GET: RegisterController
        Índice ActionResult público ( )
        {
            retornar Visão ( ) ;
        }

        // GET: RegisterController/Detalhes/5
        Public ActionResult Details ( int  id )
        {
            retornar Visão ( ) ;
        }

        // GET: RegisterController/Create
        public ActionResult Create ( )
        {
            retornar Visão ( ) ;
        }

        // POST: RegisterController/Create
        [ HttpPost ]
        [ ValidateAntiForgeryToken ]
        public ActionResult Create ( coleção IFormCollection  )
        {
            tentar
            {
                return RedirectToAction ( nameof ( Index ) ) ;
            }
            pegar
            {
                retornar Visão ( ) ;
            }
        }

        // GET: RegisterController/Edit/5
        public ActionResult Edit ( int  id )
        {
            retornar Visão ( ) ;
        }

        // POST: RegisterController/Edit/5
        [ HttpPost ]
        [ ValidateAntiForgeryToken ]
        public ActionResult Edit ( int  id ,  coleção IFormCollection  )
        {
            tentar
            {
                return RedirectToAction ( nameof ( Index ) ) ;
            }
            pegar
            {
                retornar Visão ( ) ;
            }
        }

        // GET: RegisterController/Delete/5
        public ActionResult Delete ( int  id )
        {
            retornar Visão ( ) ;
        }

        // POST: RegisterController/Delete/5
        [ HttpPost ]
        [ ValidateAntiForgeryToken ]
        public ActionResult Delete ( int  id ,  coleção IFormCollection  )
        {
            tentar
            {
                return RedirectToAction ( nameof ( Index ) ) ;
            }
            pegar
            {
                retornar Visão ( ) ;
            }
        }
    }
}

# Instruções de acesso

link de acesso: ANDRESSA INSERIR

> **Links Úteis**:
>
> - [Trabalhando com HTML5 Local Storage e JSON](https://www.devmedia.com.br/trabalhando-com-html5-local-storage-e-json/29045)
> - [JSON Tutorial](https://www.w3resource.com/JSON)
> - [JSON Data Set Sample](https://opensource.adobe.com/Spry/samples/data_region/JSONDataSetSample.html)
> - [JSON - Introduction (W3Schools)](https://www.w3schools.com/js/js_json_intro.asp)
> - [JSON Tutorial (TutorialsPoint)](https://www.tutorialspoint.com/json/index.htm)
