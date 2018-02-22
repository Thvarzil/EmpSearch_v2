

CREATE TABLE emp (
       emp_id INT,
       emp_name VARCHAR(255)
       PRIMARY KEY(emp_id)
);

INSERT INTO emp_table VALUES(0,"Alice Anderson"),(1,"Bob Brown"),(2,"Charlene Chase"),(3,"David Diaz"),(4,"Erin Eklund"),(5,"Frank Fitzgerald");

SELECT * FROM emp_table;

CREATE TABLE skill_table(
       skill_id INT,
       skill_name VARCHAR(255)
       PRIMARY KEY(skill_id)
);

INSERT INTO skill_table VALUES(0,"SQL"),(1,"HTML"),(2,"CSS"),(3,"JS"),(4,"C#"),(5,"Ruby");

SELECT * FROM skill_table;


insert into emp_skills values(0,0, 0),(1,0,4),(2,0,5),(3,1,1),(4,1,2),(5,2,3),(6,2,4),(7,3,1),(8,3,2),(9,3,3),(10,4,1),(11,4,4),(12,5,3);