# Arquitetura da Solução


Nesta parte do projeto serão exibidos os elementos técnicos propostos pela equipe, bem como parte da solução criada. Tratar-se a os componentes e do seus ambiente de hospedagem.

## Diagrama de Classes

Os compenentes básicos da solução serão apresentados conforme figura abaixo.

<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t8-pmv-ads-2023-1-e3-proj-int-t8-grupo04/blob/main/docs/img/Diagrama%20de%20Classes.png" alt="Diagrama de Classes">

## Modelo ER (Projeto Conceitual)

Abaixo segue Modelo ER representando através de um diagrama como as entidades do My CLoset se relacionam entre si na aplicação interativa.

<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t8-pmv-ads-2023-1-e3-proj-int-t8-grupo04/blob/main/docs/img/Modelo%20ER.png" alt="Modelo ER">

Sugestão de ferramentas para geração deste artefato: LucidChart e Draw.io.

## Projeto da Base de Dados

No contexto da aplicação web de gerenciamento de closet, o SQL Server Management Studio (SSMS) será utilizado para armazenar os dados relacionados às peças de roupa, usuários e outras informações relevantes. A seguir estão algumas maneiras pelas quais o SSMS será utilizado:

1. Criação do banco de dados: O SSMS será usado para criar um banco de dados no SQL Server especificamente para armazenar os dados do aplicativo de gerenciamento de closet. Isso envolverá a definição de um nome adequado para o banco de dados e a configuração de suas propriedades, como tamanho, opções de recuperação e collation.

2. Criação de tabelas: Com o banco de dados criado, o SSMS será utilizado para criar as tabelas necessárias para armazenar as informações sobre as peças de roupa, usuários e outras entidades relevantes para o aplicativo de gerenciamento de closet. Cada tabela terá colunas correspondentes aos atributos das entidades, como nome da roupa, cor, tamanho, estilo, etc.

3. Definição de relacionamentos: O SSMS permitirá a definição de relacionamentos entre as tabelas, como a relação entre um usuário e o closet associado a ele. Isso envolverá a criação de chaves estrangeiras nas tabelas relevantes para estabelecer a integridade referencial.

4. Inserção de dados: O SSMS será usado para inserir dados iniciais nas tabelas, como exemplos de peças de roupa e usuários. Isso pode ser útil para fornecer um conjunto inicial de dados para testar a funcionalidade do aplicativo de gerenciamento de closet.

5. Consulta e atualização de dados: Durante a execução do aplicativo web, o SSMS será usado para consultar e atualizar os dados armazenados no banco de dados. Os comandos SQL podem ser escritos e executados no SSMS para recuperar informações específicas sobre as peças de roupa de um usuário, adicionar ou remover itens do closet e realizar outras operações de gerenciamento de dados.

6. Otimização e manutenção: O SSMS também pode ser usado para otimizar e manter o banco de dados ao longo do tempo. Isso pode envolver a criação de índices para melhorar o desempenho das consultas, a execução de tarefas de backup e restauração dos dados, a monitorização do desempenho do banco de dados e a aplicação de atualizações de esquema conforme necessário.

## Tecnologias Utilizadas

Para a implementação da solução. Foi utilizadas as linguagens c#, HTML, CSS. O frameworks ASP.NET MVC.

<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t8-pmv-ads-2023-1-e3-proj-int-t8-grupo04/blob/main/docs/img/fluxo%20intera%C3%A7%C3%A3o%20tecnologias.png" alt="Descrição do fluxo da interação das tecnologias utilizadas">

## Hospedagem

A ambiente de Hospedagem escolhido para a  plataforma será o Azure e econtra-se no seguinte endereço https://myclosetweb.azurewebsites.net/.
O Azure é uma plataforma de computação em nuvem que oferece diversos serviços para hospedagem, gerenciamento e escalabilidade de aplicativos. Uma das formas de fazer a publicação de um aplicativo no Azure é por meio de um processo de deploy contínuo, que utiliza o Git como meio de envio de código para o ambiente de produção. Para isso, é necessário configurar um repositório remoto no Azure e vinculá-lo ao repositório local do projeto. Em seguida, o desenvolvedor pode fazer o commit das alterações no projeto e fazer o push para o repositório remoto, que irá disparar um pipeline de deploy automático. O pipeline pode incluir etapas como compilação, teste e implantação em um ambiente de produção ou pré-produção, dependendo da configuração escolhida. Esse processo automatizado de deploy contínuo via Git ajuda a reduzir os riscos de erros humanos e a aumentar a eficiência do ciclo de desenvolvimento de software, permitindo que o desenvolvedor foque na criação de novas funcionalidades e melhorias para o aplicativo.

