# TASK 1 #

<h3 align="center">Требования к задаче.</h3>
Создать приложение - аналог твиттера.
<ul>
<li>При входе в приложение высвечивается окно аутентификации, есть возможность зарегистрироваться и войти (возможен вход через сервисы vk, google)</li>
<li>Главная страница пользователя представляет собой краткое описание, фото, и личный блог.</li>
<li>Пользователь может писать твиты, которые будут отображаться на его странице, также возможно редактировать и удалять твиты</li>
<li>На главной странице отображаются лента твитов людей, на которых подписан пользователь.</li>
<li>Также есть страница со всеми твитами.</li>
<li>Доступна сортировка твитов, по популярности (за день, неделю, месяц), по дате.</li>
<li>Пользователь может подписаться на другого пользователя.</li>
<li>Посты можно лайкать и комментировать, комментарим можно редактировать и удалаять.</li>
<li>К постам можно прикладывать картинки.</li>
<li>Доступен поиск аккаунтов, сортировка по количеству подписчиков.</li>
</ul>

<h3 align="center">Дополнительные задачи:</h3>
<ul>
<li>
Есть три вида пользователей
<ul>
<li>Пользователь с обычными правами доступа.</li>
<li>Администратор. Может удалять записи и блокировать аккаунты, с указанием причины.</li>
<li>Администратор с бесконечными правами.</li>
</ul>
<li>Лента обновляется динамически, без перезагрузки страницы</li>
<li>Реализован встроенный мессенджер.</li>
<li>Можно оставить жалобу на твит, комментарий. Администратор видит эти жалобы и должен их рассматривать.</li>
</ul>

# TASK 2 #

<h2 align="center">База</h3>

<div>Вроде сущность диалог вообще не нужна, но как без нее сделать отображение чатов не знаю.

Для упрощения пока не стал реализовывать групповые чаты, а также сделал что каждый пользователь может отправлять другому пользователю сообщения.</div>

![alt text](Db.png)
