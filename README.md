### AV SERVICE JOB INTERVIEW SKILL TEST

![](https://images-ext-2.discordapp.net/external/RkdbwXvD0DjitXt0SqjfOA11D9FKMCVjg2jCAlVkNC0/https/www.avservice.it/wp-content/uploads/2020/12/avservice-logo.png?format=webp&quality=lossless)


Il Database per il test è AdventureWorks2017 scaricabile da:
https://learn.microsoft.com/en-us/sql/samples/adventureworks-install-configure?view=sql-server-ver16&tabs=ssms

utilizzare la versione AdventureWorks2017.bak

la solution è composta in 4 progetti:
- Infrastructure
- Web Application (MVC)
- Rest API
- Progetto di unit Test

Si richiede di implementare nella soluzione le seguenti parti:


Web Application (MVC):
- Implementare i metodi nella AdventureWorksServices utilizzando le tecnologie richieste (EF o DAPPER)
- Nella Cartella FILES, Inserire i corpi delle query richieste nel file .sql
- nel file index.cshtml


	<div>
	@* TODO *@
		@*Disegnare la Tabella dinamica in HTML  con i campi Title , firstname lastname*@
		@* Colorare header tabella di rosso *@
    
		@foreach (var item in Model)
		{
			<div>@item.FirstName</div>     
			<br />
		}                     
	</div>    
	<script>
		// TODO
		/*Implementare uno script javascript/jquery che converta in maiuscolo tutti i lastname che iniziano con la lettere A*/
	</script>

Rest API
- Implementare il controller con le 4 operazioni CRUD per la classe PERSON

(NICE TO HAVE)
Progetto di unit Test
- Sostiturire il AdventureWorks2017Context con un mocker

(NICE TO HAVE)
- Creare un file dockercompose per la compilazione e esecuzione dei progetti Rest API e MVC in Containers

Per la consegna eseguire un Pull Request

Per qualsiasi informazione contattere it@avservice.it oppure simone.citi@avservice.it
