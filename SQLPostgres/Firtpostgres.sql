-- // criação de tabelas //

create table Alunos  -- cria uma tabela
(
	id serial primary key, --uma primary key serve para identificar unicamente uma linha, fazendo ela nao se repetir. 
	nome varchar(100), --varchar é uma classe  que só permite condiçoes do tipo string com no maximo 100 caracteres
	idade int -- int é uma classe que permite que só numeros com 32 bits sejam armazenados na variavel
);

create table Cursos
(
	id serial primary key,
	nome varchar(100)
);

create table Matriculas
(
	id serial primary key,
	aluno_id int,
	curso_id int
);
-- // tipos de select //

select * from Alunos -- mostra a tabela Alunos...
select * from Cursos
select * from Matriculas

-- // inserir valores //

insert into Alunos (nome, idade) -- atribui valores
values ('Joao', '29'),
	   ('Maria', '31');

insert into Cursos (nome)
values ('Engenharia'),
	   ('Direito');

INSERT INTO matriculas (aluno_id, curso_id)
VALUES
(1, 1),
(2, 2);


-- // outros tipos de select, mas especificos //

select nome from Cursos

select * from Alunos
where idade >= 20;

select * from Alunos 
where nome = 'Joao';

-- select com mais de uma condição

select * from Alunos
where nome = 'Joao' and idade >=20;

-- // metodos com JOIN // 
-- sem join, verei tabelas separadas, com join, eu verei tabelas juntas 

SELECT 
    alunos.nome,     -- pega o nome do aluno (tabela alunos)
    cursos.nome      -- pega o nome do curso (tabela cursos)

FROM matriculas      -- começa pela tabela matriculas, que liga alunos e cursos

INNER JOIN alunos 
    ON matriculas.aluno_id = alunos.id
    -- liga matriculas com alunos:
    -- aluno_id (FK) aponta para o id (PK) do aluno

INNER JOIN cursos 
    ON matriculas.curso_id = cursos.id;
    -- liga matriculas com cursos:
    -- curso_id (FK) aponta para o id (PK) do curso

