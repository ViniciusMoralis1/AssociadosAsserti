# AssociadosAsserti
Projeto desenvolvido na Matéria de Desenvolvimento de Sistemas de Informação com auxilio do professor Fábio Navarro

<h2><b>Nome dos Alunos: </b></h2>

Allan Morishigue – 567485<br/>
Breno Dadalto – 567681<br/>
Fellipe Emanoel – 554774<br/>
Lucas de Souza – 569534<br/>
Vinicius Moralis – 568600<br/>


<h2><b>Observação:</h2></b>

É necessário realizar a alteração da conexão com o banco

<code>
public AssociadosAsserti_AssociadosDataContext() : base(@"passar aqui sua conexao com o BD")

        {
            Configuration.ProxyCreationEnabled = false;
        }
</code>
        
<i>Caminho: (Infra/AssociadosAsserti.Infra/Context/AssociadosAsserti_EmpresaDataContext.cs)</i>
