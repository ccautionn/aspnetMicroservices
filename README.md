# aspnetMicroservices
aspnetMicroservices

## Postgres User Creation

dockerize edilen postgresql için kullanıcı oluşturma işlemleri developer terminal üzerinden yapılabilir.

öncelikle docker üzerinden bash terminal bağlantısı yapıyoruz. 

```bash
docker exec -it discountdb /bin/bash
```

Daha sonra postgres kullanıcısı ile postgresql e bağlantı kuruyoruz
```bash
psql -U postgres //postgres user ile psq bağlantısı
```

ve istediğimiz user ı yaratıyoruz.

```bash
su - postgres
createuser --interactive --pwprompt
```

1. At the Enter name of role to add: prompt, type the user's name.
2. At the Enter password for new role: prompt, type a password for the user.
3. At the Enter it again: prompt, retype the password.
4. At the Shall the new role be a superuser? prompt, type y if you want to grant superuser access. Otherwise, type n.
