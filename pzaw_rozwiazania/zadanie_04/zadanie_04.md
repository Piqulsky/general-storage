Celem zadania jest implementacja serwera w `javascript` wykorzystując `node.js`, który będzie obsługiwał rejestrację konta oraz uwierzytelnianie. Dodatkowo należy zaimplementować stronę www, która będzie udostępniała widok dla użytkownika (rejestracja, panel logowania, zawartość po zalogowaniu).

W trakcie implementacji serwera można korzystać z różnych frameworków, które usprawnią implementację. Serwer nie musi posiadać żadnej zewnętrznej bazy danych SQL lub NoSQL. Wystarczy przechowywać dane w pliku json lub w pamięci RAM. Pamiętaj, aby nie przechowywać haseł za pomocą `plain textu`. Wykorzystaj `bcrypt`, który utworzy hash dla hasła, a ten hash zostanie zapamiętany.

Zaimplementuj sesję za pomocą `express-session`, która umożliwi tobie zachowanie zalogowanego użytkownika, który zalogował się do systemu, lecz wyłączył kartę i wszedł ponownie na stronę (należy sprawdzić, czy sesja jeszcze istnieje, jeśli tak, to należy przekierować widok użytkownika na zawartość po zalogowaniu, jeśli nie to należy wyświetlić panel logowania).

Frameworki, które mogą się przydać przy implementacji serwera:
- express
- cors
- nodemon
- env
- bcrypt
- express-session

Frameworki, które mogą się przydać przy implementacji clienta:
- react, angular, view
- axios, superagent

Aplikacje zewnętrzne, które mogą się przydać do testowania:
- postman, curl
- selenium

---

Dalsze zadania:
- dodanie bazy danych SQL lub NoSQL (SQL -> baza danych w xampp, NoSQL -> rozwiązanie dostosować do możliwości systemów operacyjnych znajdujących się w szkole)
- należy utworzyć role w systemie (czytelnik, twórca, administartor)
    - czytelnik, jest wstanie przeglądać zawartość treści (artykułów) oraz dodawać komentarze, dodawać `+` lub `-` do artykułu
    - twórca, jest wstanie robić to samo co `czytelnik`, lecz może dodawać nowe artykuły
    - administrator, jest wstanie robić to samo co `czytelnik` oraz `twórca`, lecz posiada on możliwość kasowania/ukrywania komentarzy/artykułów
- kolejnym etapem jest dodanie weryfikacji dwu etapowej (Time-based One-Time Password (TOTP))
