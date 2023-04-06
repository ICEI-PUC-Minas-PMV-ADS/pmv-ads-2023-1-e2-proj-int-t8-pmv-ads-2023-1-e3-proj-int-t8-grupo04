# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Os cenários de testes demostram que os Requisito Funcionais foram satisfatóri. 

Os casos de testes foram enumera e cada um deles está(ão) correto(s) - de acordo com o que foi definido na seção "2 - Especificação do Projeto".

| **Caso de Teste** 	| **CT-01 – Cadastrar perfil** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - O web site deve oferecer ao usuário a possibilidade de cadastro/login no site, onde através da funcionalidade acessar o seu closet.|
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar no aplicativo. |
| Passos 	| - Acessar o aplicativo My Closet <br> - Informar o acessar a guia de cadastro<br> - Clicar em "Criar conta" <br> - Preencher os campos obrigatórios (estilo, roupas de calor, roupas de frio, camisetas, shorts, calças, sapatos, assessórios, senha confirmação de senha e acesso biométrico) <br> - Aceitar os termos de uso <br> - Clicar em "Cadastrar" |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-02 – Funcionalidade Peças Favoritas	|
|Requisito Associado | RF-002	- O web site/aplicativo deve exibir as peças preferidas, por parte dos usuários, no botão “peças favoritas”. |
| Objetivo do Teste 	| Cadastro de todas as peças (roupas e acessórios preferidos). |
| Passos 	| - Acessar o aplicativo My Closet <br> - Clicar no botão "Peças favoritas" <br> - Preencher as peças por categoria (roupas, sapatos e acessórios) <br> - Clicar em "Salvar" |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-03 – Funcionalidade Pesquisa	|
|Requisito Associado | RF-003	- O site/aplicativo deve ter uma funcionalidade de pesquisa na página principal. | 
| Objetivo do Teste   | Pesquisar sobre  estilos e combinações (com base nas peças cadastradas), roupas/acessórios e se a mesma (o)encontra-se disponível para uso.|
| Passos 	| - Acessar o aplicativo My Closet <br> - Clicar no botão "Pesquisa" <br> - Digitar o estilo pretendido e/ou nome da peça (roupa ou acessório) <br> - Clicar em "Buscar" |
|Critério de Êxito | - Estilo /peça (roupa ou acessório) localizada (o) com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-04 – Funcionalidade Pesquisa avançada	|
|Requisito Associado | RF-004	- O site deve conter um filtro para encontrar peças com mais facilidade. | 
| Objetivo do Teste   | Pesquisar avançada e direcionadas com base na cor, categoria, estilo, marca. |
| Passos 	| - Acessar o aplicativo My Closet <br> - Clicar no botão "Pesquisa Avançada" <br> - Digitar o nome da peça (roupa ou acessório) e /ou a marca da roupa e /ou o estilo pretendido <br> - Clicar em "Buscar" |
|Critério de Êxito | - Peça e /ou catalogado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-05 – Funcionalidade Inclusão / Exclusão	|
|Requisito Associado | RF-005	- O site/aplicativo deve permitir ao usuário a inclusão/cadastro de suas roupas bem como a remoção de peças.| 
| Objetivo do Teste   | Inclusão ou exclusão de roupas e acessórios. 
| Passos 	| - Acessar o aplicativo My Closet <br> - Clicar no botão "Inclui ou Excluir" <br> - A inclusão exigirá uma riqueza maior de detalhes (cor, estilo, verão ou inverno), sapatos (cor, de salto ou rasteirinha, casual ou social). A exclusão se concretizara com a busca da peça/acessório. | <br> 
|Critério de Êxito | - Peça e /ou Acessório inserida ou excluída com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-06 – Composição de looks	|
|Requisito Associado | RF-006	- O site/aplicativo deve permitir ao usuário uma composição de looks, mediante peças cadastradas.| 
| Objetivo do Teste   | Montagem de diferentes looks presentes no acervo cadastrado 
| Passos 	| - Acessar o aplicativo My Closet <br> - Clicar no botão "Criar looks" <br>  - Digitar o look pretendido para a ocasião <br> - Clicar em "Montar" |
|Critério de Êxito | - look confeccionado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-07 – Compartilhamento em redes sociais	|
|Requisito Associado | RF-007	- O site/aplicativo deve permitir o compartilhamento de seu visual, através de mídias sociais.| 
| Objetivo do Teste   | Após inserção de novas peças e acessórios bem como a montagem de looks, o aplicativo contará com o botão de compartilhamento, podendo o usuário escolher em qual mídia/rede social divulgará sua aquisições ou looks escolhidos.  
| Passos 	| - Acessar o aplicativo My Closet <br>  - Escolher o canal <br> Clicar no botão "Compartilhar" |
|Critério de Êxito | - Informações compartilhadas com sucesso. |
 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
