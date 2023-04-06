
# Metodologia

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Documentação de Especificação</a></span>

  A metodologia engloba as ferramentas e plataformas escolhidas para auxílio no desenvolvimento do Projeto. Essas ferramentas serão utilizadas com o intuito de organização de tempo/tarefas a serem executadas por cada membro da equipe, para a manutenção dos códigos, para criação de artefatos e gerenciamento do time na execução das tarefas do projeto.
  Para o desenvolvimento das etapas foram utilizadas as seguintes ferramentas: O hambiente de trabalho foi o Microsoft teams a fim de reunirmos e trabalharmos juntos; Visual Studio 2019 para a estrutura e gestão do código fonte; GitHub como repositório e organizador de sprints e tarefas e Git para controle de versões; Figma para realizar o design do layout do front-end; e Lucidchart e Astah para a confecção do diagrama de caso de uso.

## Controle de Versão

A ferramenta de controle de versão adotada no projeto foi o
[Git](https://git-scm.com/), sendo que o [Github](https://github.com)
foi utilizado para hospedagem do repositório.

O projeto segue a seguinte convenção para o nome de branches:

- `main`: versão estável já testada do software
- `unstable`: versão já testada do software, porém instável
- `testing`: versão em testes do software
- `dev`: versão de desenvolvimento do software

Quanto à gerência de issues, o projeto adota a seguinte convenção para
etiquetas:

- `documentation`: melhorias ou acréscimos à documentação
- `bug`: uma funcionalidade encontra-se com problemas
- `enhancement`: uma funcionalidade precisa ser melhorada
- `feature`: uma nova funcionalidade precisa ser introduzida

A configuração do projeto no GitHub foi feita seguindo os seguintes passos:
Criou-se um repositório; Configuraram-se as opções do repositório, após criar o repositório, foram feitas configurações para personalizar o projeto, como a descrição, o arquivo README, as licenças e outras configurações; Adicionaram-se colaboradores: foi possível adicionar colaboradores ao projeto, concedendo-lhes permissões de acesso ao repositório (todos como adm); Foi feita a configuração sas branchs: as branchs são uma parte fundamental da estrutura do projeto e devem ser configuradas de acordo com as necessidades do projeto. Para isso, é possível criar novas branchs, definir as regras de acesso e configurar o fluxo de trabalho; Configuraram-se as issues: as issues eram uma maneira eficiente de gerenciar e rastrear tarefas e problemas no projeto. Para configurar as issues, podemos definir as labels, atribuir responsáveis e configurar as notificações; Configuramos as permissões: as permissões eram uma parte importante da configuração do projeto, pois definiam quem tinha acesso a quais recursos do repositório, como todos os mesmos são parte da equipe foi dada a permissão de adm a todos; Esses foram apenas as configurações que utilizamos para realizar o projeto no GitHub. A plataforma oferece muitas outras opções e recursos que poderiam ser utilizados para personalizar e gerenciar projetos de acordo com as necessidades.
A gerência de tags, merges, commits e branchs foram feitas seguindo as seguintes etapas: Criação de branchs para permitir que os colaboradores de um projeto trabalhem em diferentes versões do código ao mesmo tempo, sem interferir no trabalho uns dos outros. A realização de Commits para salvar as alterações realizadas nos arquivos do repositório. Cada commit é uma versão específica do código, que inclui as alterações feitas desde o último commit, importante sempre adicionar comentários sobre o que se trata a alteração; São feitas merges para combinar em uma única versão alterações feitas em diferentes versões do código, tornando mais fácil o gerenciamento das alterações e  para manter uma única versão principal do projeto. Já a utilização de tags serão para marcar pontos específicos na linha do tempo de um projeto, como releases, versões ou marcos importantes.
A gerência de issues no GitHub é importante para rastrear tarefas, problemas, bugs e solicitações de recursos do projeto, permitindo que a equipe criasse, discutisse e resolvessem problemas relacionados ao projeto em um único local.

## Gerenciamento de Projeto

A equipe usa metologias ágeis para auxiliar no gerenciamento, o Scrum foi o método escolhido como base na execução do processo de desenvolvimento deste projeto.

A ferrramenta utilizada no Projeto para auxiliar na organização, gestão do tempo e distribuição das tarefas é o GitHub, através da criação de um Dashboard dentro do mesmo. Esse board será constantemente atualizado de acordo com a desenvolvimento do projeto.

Segue abaixo um resumo sobre a disposição das listas:

- **Backlog (A fazer):** abriga todas as tarefas a serem executdas para que o desenvolvimento do porojeto aconteça, representa o Product Backlog. Todas as atividades identificadas no decorrrer do projeto também devem ser incorporadas a esta lista.

- **Em andamento:** nesta lista estão as tarefas a serem executadas durante o Sprint corrente e representa o Sprint Backlog. Aqui fica definido o que cada integrante fará durante a etapa.

- **Doing (To do):** quando uma tarefa tiver sido iniciada, ela é movida para cá.

- **Revisão:** as tarefas concluídas devem ser movidas para essa lista, onde passam por uma revisão final antes de serem concluídas.

- **Done (Concluída):** nesta lsta serão alocadas as tarefas que passarem pelos teste e controle de qualidade e estão aptas a serem entregues ao usuário/cliente. Não há mais edições ou revisões necessárias, eles está agendado e pronto para a ação.

- **Entregue:** quando as tarefas forem entregues, as mesmas serão alocadas nessa lista.

### Divisão de Papéis

A equipe foi organizada, conforme abaixo, da seguinte maneira:

- **Scrum Master:** Andressa Guedes

- **Product Owner:** Andressa Guedes

- **Equipe de Desenvolvimento:** . Andressa Guedes
                                 . Felipe Viana
                                 . Luana Scardua
                                 . Sanderlei Cabral
                                 
- **Equipe de Design:** . Felipe Viana
                        . Luana Scardua
                        . Sanderlei Cabral

> **Links Úteis**:
> - [11 Passos Essenciais para Implantar Scrum no seu 
> Projeto](https://mindmaster.com.br/scrum-11-passos/)
> - [Scrum em 9 minutos](https://www.youtube.com/watch?v=XfvQWnRgxG0)

### Processo

Conforme especificado anteriormente, uma vez definido o Scrum como metodologia de desenvolvimento do software, segue abaixo os detalhes sobre a implementação deste no projeto.

- A equipe Scrum é composta pela Scrum Master e Product Owner Andressa Guedes, e pela equipe de desenvolvimento e design, composta pelos seguintes membros: Felipe Viana, Luana Scardua e Sanderlei Cabral.

- A Scrum Master será responsável por garantir que a equipe siga as práticas do Scrum e remova os impedimentos que possam surgir. Uma vez que também está no papel  de Product Owner, Andressa Guedes será responsável por priorizar o backlog do produto, ou seja, a lista de funcionalidades baseadas nos requisitos do projeto, que por sua vez foram apurados tendo como base as necessidades do cliente.

- A equipe de desenvolvimento e design será responsáveis por entregar o trabalho tendo como base o tempo definido no Sprint. Sprint é o período fixo que a equipe scrum possuirá para entregar um conjunto de funcionalidades pré-estabelecidos no Dashboard.

- Durante o projeto reuniões serão feitas durante a semana visando discutir o progresso do trabalho, cada qual com uma temática diferente, conforme segue abaixo.

  . **Reunião de acompanhamento:** cada membro da equipe compartilha o que fez desde o último encontro, o que planeja fazer até a próxima reunião e eventuais impedimentos que possam estar travando o progresso do projeto.
  
  . **Reunião para revisão do sprint:** nesse encontro a equipe Scrum apresenta o trabalho concluído durante o sprint. O Product Owner e outras partes interessadas podem fornecer feedback sobre o trabalho concluído e revisar o backlog do produto.
  
  . **Reunião de retrospectiva do sprint:** a retrospectiva do sprint é uma reunião em que a equipe Scrum revisará o sprint anterior para identificar áreas de melhoria. A equipe poderá discutir o que funcionou bem, o que não funcionou tão bem e quais mudanças podem ser feitas para melhorar o processo no futuro.

Esses são alguns dos principais detalhes da utilização do Scrum no projeto. É importante lembrar que o Scrum é uma metodologia flexível sendo assim adaptações podem ser feitas visando atender às necessidades específicas da equipe e/ou do projeto.

 
> **Links Úteis**:
> - [Project management, made simple](https://github.com/features/project-management/)
> - [Sobre quadros de projeto](https://docs.github.com/pt/github/managing-your-work-on-github/about-project-boards)
> - [Como criar Backlogs no Github](https://www.youtube.com/watch?v=RXEy6CFu9Hk)
> - [Tutorial Slack](https://slack.com/intl/en-br/)

### Ferramentas

O projeto está sendo desenvolvido com o auxílio das seguintes ferramentas, conforme apresentado à baixo:

- **Repositório de Código Fonte:** GitHub (https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t8-pmv-ads-2023-1-e3-proj-int-t8-grupo04)
- **Gerenciamento do Projeto:** GitHub
- **Ferramenta de Comunicação:** Microsoft Teams
- **Editor de Código:** Visual Studio v.2019
- **Ferramentas de desenho de tela (_wireframing_), diagramas e fluxogramas:** .Figma .LucidChart

A ferramente utilizada como repositório de códio fonte, foi o GitHub. Sua escolha foi feita pois além de funcionar como um repositório, também nos fornece mecanismos para gereciar o projeto em sí, mantendo toda a equipe informada e sincronizada com relação às tarefas baseadas na metodologia Scrum. 

O editor de código, Visual Studio v. 2019, foi escolhido porque possui uma melhor integração com o sistema de versão. 

A ferramenta de comunicação utilizada, Microsoft Teams, além de suprir as necessidade da equipe com relação a chamadas de video, chat etc é bem intuitiva e facilita bastante o trabalho.

Por fim, para criarmos Diagramas e Wireframes utilizamos o LucidChart e o Figma, pois entendemos que estes melhor traduzem as nossas necessidades e do projeto também.

 
> **Possíveis Ferramentas que auxiliarão no gerenciamento**: 
> - [Slack](https://slack.com/)
> - [Github](https://github.com/)
