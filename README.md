# TestRefit
## Среда разработки 
- Visual studio 2022
- Бд Workbench
- EntityFramework
- MediatR
- AutoMapper
- Refit

**Необходимо запустить миграцию Update-Database**

В данном решение 3 проекта Asp net core
1. TestRefit
Первый микросервис, который вносит изменения в Бд
2. TestRestClient
Проект содержащий интерфейс для коннекта к микросервису 1 (TestRefit)
3. TestWebApi
Второй микросервис, который обращается к микросервису 1 (TestRefit) через интерфейс 2го прокта (TestRestClient)
