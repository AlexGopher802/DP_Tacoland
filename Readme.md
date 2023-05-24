# Tacoland

## Как запустить приложение?

* Запустите docker
* Введите в консоль следующую команду: `docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=AMS25051980s34!" -p 1434:1433 --name sqlserver -h sqlserver -d alexgopher/sqlserver`
* Запустите файл по пути: `CafeOrdering/bin/Debug/net6.0-windows/CafeOrdering.exe`