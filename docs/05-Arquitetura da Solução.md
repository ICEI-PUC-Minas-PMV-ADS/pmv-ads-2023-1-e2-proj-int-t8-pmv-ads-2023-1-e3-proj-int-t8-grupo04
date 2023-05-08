# Arquitetura da Solução


Nesta parte do projeto serão exibidos os elementos técnicos propostos pela equipe, bem como parte da solução criada. Tratar-se a os componentes e do seus ambiente de hospedagem.

## Diagrama de Classes

Os compenentes básicos da solução serão apresentados conforme figura abaixo.

![Diagrama de Classes](docs/img/Diagrama de Classes.png)

## Modelo ER (Projeto Conceitual)

Abaixo segue Modelo ER representando através de um diagrama como as entidades do My CLoset se relacionam entre si na aplicação interativa.

![Modelo ER](docs/img/Modelo ER.png)

Sugestão de ferramentas para geração deste artefato: LucidChart e Draw.io.

## Projeto da Base de Dados

Um arquivo JSON (JavaScript Object Notation) é um formato de dados leve e fácil de ler e escrever, que é amplamente utilizado em aplicativos da web para armazenar informações. No caso de um cadastro de aplicação web, um arquivo JSON pode ser usado para armazenar os dados do usuário, como nome, endereço de e-mail, número de telefone, senha, entre outros. Esses dados podem ser organizados em um objeto JSON, com cada atributo representando um campo do formulário de cadastro. Quando um usuário preenche o formulário, os dados são enviados para o servidor da aplicação, que os converte em um objeto JSON e os armazena em um arquivo em disco ou em um banco de dados. O arquivo JSON pode ser acessado posteriormente para recuperar informações do usuário e preencher formulários de edição de perfil, por exemplo. O uso de arquivos JSON para armazenamento de dados de cadastro em uma aplicação web pode ser uma solução simples e eficiente, além de permitir a fácil integração com outras tecnologias da web.

## Tecnologias Utilizadas

Para a implementação da solução. Foi utilizadas as linguagens c#, HTML, CSS. O frameworks ASP.NET MVC.

<img src="[URL_DA_IMAGEM](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t8-pmv-ads-2023-1-e3-proj-int-t8-grupo04/blob/4041e70df1a866a79716cf96851ab557e41d3259/docs/img/fluxo%20intera%C3%A7%C3%A3o%20tecnologias.png)" alt="Descrição do fluxo da interação das tecnologias utilizadas">

## Hospedagem

A ambiente de Hospedagem escolhido para a  plataforma será o Azure e econtra-se no seguinte endereço https://myclosetweb.azurewebsites.net/.
O Azure é uma plataforma de computação em nuvem que oferece diversos serviços para hospedagem, gerenciamento e escalabilidade de aplicativos. Uma das formas de fazer a publicação de um aplicativo no Azure é por meio de um processo de deploy contínuo, que utiliza o Git como meio de envio de código para o ambiente de produção. Para isso, é necessário configurar um repositório remoto no Azure e vinculá-lo ao repositório local do projeto. Em seguida, o desenvolvedor pode fazer o commit das alterações no projeto e fazer o push para o repositório remoto, que irá disparar um pipeline de deploy automático. O pipeline pode incluir etapas como compilação, teste e implantação em um ambiente de produção ou pré-produção, dependendo da configuração escolhida. Esse processo automatizado de deploy contínuo via Git ajuda a reduzir os riscos de erros humanos e a aumentar a eficiência do ciclo de desenvolvimento de software, permitindo que o desenvolvedor foque na criação de novas funcionalidades e melhorias para o aplicativo.

