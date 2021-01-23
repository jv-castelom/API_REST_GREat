# API_REST_GREat
Desafio Analista de Sistemas Junior

---------------------------------------------!!!!!-------------------------------------------------------
Explicação para execução do projeto:

Primeiro passo configurar a String de conexão:
Em appsettings.json tem uma lista chamada ConnectionStrings,  
substituir a String Default pela sua string de conexão.

Ex:"Default": "Password=admin123456;Persist Security Info=True;User ID=sa;Initial Catalog=userdb;Data Source=DESKTOP-S2DRI4F\\SQLSERVERGREAT"

Segundo passo Criação do BD

via EFC migration -> Abrir o console gerenciador de pacotes -> type Update-Database
via Script -> Em *\API_REST_GREat\API_REST_GREat.Repo\ScriptDb tem o arquivo script.sql que pode ser 
              executado diretamente através do SqlServer Management Studio.

Terceiro passo Executar a Web API.

Quarto passo Abrir as páginas html direto no navegador:

Vá onde está o projeto Front-End_GREat e abra qualquer uma das 2 páginas html (Preferência GoogleChrome).
O front-end já pode consumir a API.


Observãções: A API está setada para escutar na porta 27816 verifique se não existe outro serviço na mesma porta.

---------------------------------------------!!!!!-------------------------------------------------------
