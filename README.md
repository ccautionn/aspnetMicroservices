# aspnetMicroservices
aspnetMicroservices

## Postgres User Creation

dockerize edilen postgresql için kullanıcı oluşturma işlemleri developer terminal üzerinden yapılabilir.

```bash
psql -U postgres //postgres user ile psq bağlantısı
```


```bash
sudo -u postgres psql
postgres=# create database mydb;
postgres=# create user myuser with encrypted password 'mypass';
postgres=# grant all privileges on database mydb to myuser;
```
