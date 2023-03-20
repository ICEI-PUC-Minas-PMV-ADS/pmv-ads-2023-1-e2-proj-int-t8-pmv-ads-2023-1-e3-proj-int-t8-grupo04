# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

A definição dos problemas e necessidades detectados para idealizar esse projeto, advém principalmente de trabalhos de imersão feitos pelos integrantes do grupo. Foram feitas pesquisas através de artigos, reportagens, vídeos e conversas com pessoas que se encaixam no perfil do público-alvo;

## Personas

Personas - As personas levantadas durante o processo de entendimento do problema são apresentadas no quadro a seguir.

Nome: Joana

Idade:22 anos

Ocupação: Mestrado na área de Arquitetura.

Salário: 2.500,00

Estado civil: Solteira

Hobbies:
Fazer trilha;
Ler;
Ouvir Música;
Cozinhar.

Características: 
Calma;
Dedicada;
Comprometida;
Vegana;
Feminista;
 Minimalista;
Engajada em causas sociais;
Adora animais de estimação e a natureza.

Valores/Crenças: Acredita em consumo consciente e preservação ambiental;
Consome somente o necessário;
Acredita que menos é mais 

Aplicativos: 
Canvas
Instagram
Twitter
Pinterest

Frustrações:
Consumismo exacerbado;
Descaso com a natureza e o planeta;
Capitalismo Desenfreado;
Não conseguir fazer mais pelo planeta.

Motivações: 
Ser uma pessoa melhor a cada dia;
Ajudar as pessoas e o planeta;
Criar projetos de moradias sustentáveis.


Nome: Laura

Idade: 29 anos

Ocupação: Médica

Salário: 12.000,00

Estado civil: Noiva

Hobbies:
Viajar;
Ler;
Sair com as amigas;
Conhecer bons restaurantes;
Comprar roupas, bolsas e sapatos.

Características: 
Extrovertida;
Determinada;
Independente;
Consumista (mas quer melhorar);
Focada na carreira;
Não quer ter filhos;

Valores/Crenças: Acredita que o sucesso só depende do seu esforço e trabalho;
É leal a ela mesma e aos seus objetivos;
Quem não vai à luta perde a batalha.

Aplicativos:
Instagram
Twitter
Linkedin
Pinterest
Mojo

Frustrações:
É  muito perfeccionista e isso acaba atrapalhando um pouco;
Não ter conseguido fazer uma especialização internacional;
Não abriu seu próprio consultório ainda

Motivações: 
Ser uma profissional extremamente bem sucedida;
Comprar uma casa linda e se casar;
Ajudar muitos pacientes através do seu trabalho;
Tentar ser um pouco menos consumista.


Nome: Clara

Idade: 32 anos

Ocupação: Empresária (empresa de consultoria de imagem)

Salário: Entre 20.000,00 e 30.000,00

Estado civil: Casada com um filho.

Hobbies:
Viajar;
Correr;
Ficar com a família;
Ler;
Sair para teatros e museus;
Cozinhar;
Conhecer cafeterias;

Características: 
Trabalha muito;
Determinada;
Muito apaixonada pela família,
Dedicada;
Detalhista;
Vaidosa.

Valores/Crenças: Acredita que a aparência importa, por isso trabalha no ramo de consultoria de imagem;
Você deve ser vestir para o cargo que deseja alcançar;
Trabalhar é servir e isso é o que move o ser humano;
Todo meu esforço é pela minha família.
A família é a base do sucesso.

Aplicativos: 
Revistas de modas;
Instagram;
Pinterest;

Frustrações:
Não poder aumentar a família;
Morar longe dos pais;
Dificuldade de empreender no país

Motivações: 
Ter uma família feliz e unida;
Ser bem sucedida;
Ajudar mulheres a se sentirem mais bonitas, valorizadas e poderosas através do seu trabalho.
Comprar uma casa no campo;

## Histórias de Usuários

A partir da compreensão do dia a dia das personas identificadas para o projeto, foram registradas as seguintes histórias de usuários.

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Joana | fazer uso das funcionalidades do app para catalogar todas as minhas peças de roupas, sapatos e acessórios |criar mais  combinações de looks, mesmo com poucas peças|
|Joana | fazer uso das funcionalidades do app para ter um estilo próprio e autêntico, mas sem cair na armadilha do consumo desenfreado | de forma criativa e consciente, fugir das amarras do consumismo. promovendo um mundo mais equilibrado no âmbito ambiental e pessoal|
|Joana| fazer uso das funcionalidades do app para diminuir meu consumo de roupas descartáveis e desnecessárias | promover um estilo de vida mais minimalista e sustentável|
|Laura | fazer uso das funcionalidades do app para adotar uma mentalidade minimalista em relação à moda com foco nas roupas que realmente preciso, coibindo assim compras impulsivas | reduzir o consumo de peças de roupas novas e investir em peças de qualidade, com maior durabilidade e versatilidade |
|Laura| fazer uso das funcionalidades do app para catalogar peças velhas, gastas | reparar itens danificados e doar a terceiros|
|Laura|fazer uso das funcionalidades do app para rastrear peças e acessórios em desuso | trocar e assim adquirir peças multifuncionais e ecológicas|
|Clara|fazer uso das funcionalidades do app ter mais praticidade, agilidade e foco na vestimenta da ocasião |assessoria visual na montagem de looks diários|
|Clara|fazer uso das funcionalidades do app priorizar o consumo e novas aquisições de peças mais duráveis |evitar o consumo de produtos sintéticos e de difícil decomposição |
|Clara|fazer uso das funcionalidades do app e organizar o meu closet por segmento de uso (descolado, empresarial, moda praia, inverno, etc) |evitar compras de itens que já possuo, bem como itens que não combine com o que já tenho|

## Requisitos

A fase inicial do desenvolvimento de um software passa pela definição e elaboração de seus requisitos funcionais, que apresentam as possibilidades de interação entre o usuário e o programa, bem como a definição de seus requisitos não funcionais que são aqueles que norteiam os aspectos que o sistema deve apresentar de qualidade e construção. Ambos serão apresentados a seguir. 

### Requisitos Funcionais

A Tabela a seguir apresenta os requisitos funcionais do projeto, bem como suas prioridades de desenvolvimento e entrega.

|ID    | Descrição do Requisito                                                                                                             | Prioridade |
|------|------------------------------------------------------------------------------------------------------------------------------------|------------|
|RF-001| O web site deve oferecer ao usuário a possibilidade de cadastro/login no site, onde através da funcionalidade acessa o seu closet. |    MÉDIA   | 
|RF-002| O web site/aplicativo deve exibir as peças preferidas, por parte dos usuários, no botão “peças favoritas”.                         |    MÉDIA   |
|RF-003| O web site/aplicativo deve ter uma funcionalidade de pesquisa na página principal.                                                 |    ALTA    |
|RF-004| O site deve conter um filtro para encontrar peças com mais facilidade.                                                             |    ALTA    |
|RF-005| O web site/aplicativo deve permitir ao usuário a inclusão/cadastro de suas roupas bem como a remoção de peças.                     |    ALTA    |
|RF-006| O web site/aplicativo deve permitir ao usuário a composição de looks, mediante as peças cadastradas.                               |    MEDIA   |
|RF-007| O web site/aplicativo deve permitir o compartilhamento de seus look, através de mídias sociais.                                    |    MEDIA   |         

### Requisitos não Funcionais

A tabela a seguir apresenta então os requisitos não funcionais do projeto, apresentando também as prioridades quanto ao desenvolvimento e entrega.

|ID     | Descrição do Requisito                                                                                                                      |Prioridade |
|-------|---------------------------------------------------------------------------------------------------------------------------------------------|-----------|
|RNF-001| O web site/aplicativo deve apresentar as peças em, no máximo, 4 segundos.                                                                   |   MÉDIA   | 
|RNF-002| O web site/aplicativo deve funcionar 24h por dia, todos os dias da semana.                                                                  |   ALTA    | 
|RNF-003| O web site deve ser responsivo, de maneira a permitir a visualização adequada por meio de dispositivo móvel.                                |   ALTA    |
|RNF-004| O web site/aplicativo deve permitir que o usuário complete o cadastro em média 1 minuto.                                                    |   BAIXA   |
|RNF-005| O web site/aplicativo deve ter compatibilidade com os principais navegadores, quais sejam, Firefox, Microsoft Edge, Google Chrome e Safari. |   ALTA    |
|RNF-006| O web site/aplicativo deve apresentar, um menu de categorias.                                                                               |   ALTA    |


## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID   | Restrição                                                                 |
|-----|---------------------------------------------------------------------------|
|RE-01| O projeto deverá ser entregue até a data limite de 19/06/2023.            |
|RE-02| O aplicativo se restringe à linguagem c# back-end.                        |
|RE-03| A equipe do projeto não poderá subcontratar o desenvolvimento do projeto. |

Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.


## Diagrama de Casos de Uso

docs/img/Diagrama Crud.jpeg
