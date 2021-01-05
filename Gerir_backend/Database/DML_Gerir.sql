Use Gerir;

USE Gerir;

INSERT INTO Usuários (Id, Nome, Email, Senha, Tipo) VALUES (NEWID(), 'Nicole', 'nicole@email.com', '123456', 'Comum');

UPDATE Usuários SET Tipo = 'Administrador' WHERE Id = '39070B5C-10A4-43B8-9F68-31BE6BCCF2E8'

UPDATE Tarefas SET DataEntrega = '04-01-2021 18:00:00'

INSERT INTO Tarefas (Id, Título, Descrição, Categoria, DataEntrega, Status, Usuario_Id) VALUES (NEWID(), 'Despertador', 'Progamar um despertador','Programação', '2021-01-05 23:59:59', '0','07EC0BC0-D2BC-4E73-9545-3A53D2630D0C');

SELECT 
u.Id as id_Usuário,
u.Nome,
u.Email,
t.Id as Id_Tarefa,
t.Título,
t.Descrição,
t.Categoria,
t.Status,
t.DataEntrega
FROM Usuários u
INNER JOIN Tarefas t ON t.Usuario_Id = u.Id 

SELECT * FROM Tarefas