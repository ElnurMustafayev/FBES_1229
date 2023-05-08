drop login elnur
--drop role developers

create login elnur with password = 'elnur'
create login templogin with password = 'templogin'
create login [last] with password = 'last'

create user testUser for login elnur
create user testUser2 for login templogin
create user testUser3 for login [last]
create role developers

alter role developers
add member testUser3

GRANT SELECT ON People TO developers
GRANT SELECT ON Genders TO developers
GRANT INSERT ON People TO developers
GRANT INSERT ON Genders TO developers
GRANT DELETE ON People TO developers
GRANT DELETE ON Genders TO developers
GRANT UPDATE ON People TO developers
GRANT UPDATE ON Genders TO developers

--GRANT USE Cars TO elnur
--use Cars;
--go
GRANT SELECT ON People TO testUser
GRANT INSERT ON People TO testUser

DENY INSERT ON People TO testUser
REVOKE INSERT ON People TO testUser

--Grant
--Deny
--Revoke