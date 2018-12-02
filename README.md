# dotnetcoreAndAngularDemo
course on udemy => Build an app with ASPNET Core and Angular from scratch 

# 1-initial commit
  => dotnet webapi oluşturuldu <br />
  => dotnet new webapi -o DatingApp.API -n DatingApp.API<br />
  => vs code extension'ları kuruldu<br />
  => ControllerBase, MVC controller without view support | Controller, MVC controller with view support and advantage of the auto binding <br />
  => [ApiController] kullanılan controller için 'Automatic model state validation' ve 'Automatic inferring of parameter binding' ([FromBody] kullanıma gerek kalmıyor). Ayrıca ApiControllerAttribute oldukça esnek şekilde customize edilebiliyor. İstenilen özellikler enable-disable edilebiliyor. (ApiBehaviorOptions) <br />
  => dotnet run - dotnet watch run <br />
  => CodeFirst db oluşturuldu. DbContext'ten kalıtım alarak entityler oluşturuldu. ConfigureServices metoduna DbContext eklendi. (dotnet ef migrations add MigrationName) (dotnet ef database update) <br />
  => angular projesi @angular/cli ile oluşturuldu. (ng new DatingApp-SPA) <br />
  => ng serve ile client yayınlandı <br />

# 2-authController added
  => Password şifreli bir şekilde jwt kullanılarak db ye kayıt edilir yapıldı.<br />
  => Repository pattern implemente edildi<br />
  => Register, login metodları yazıldı<br />
  => Authentication middleware oluşturuldu. <br />
  
# 3-client side login register
  => Bootstap kullanılarak navbar oluşturuldu. (https://getbootstrap.com/docs/4.1/examples/)<br />
  => Template form kullanıldı ve input/form state'leri incelendi. *ngIf, *ngFor kullanıldı<br />
  => Angular servisleri kullanıldı <br />
  => Komponentler arası veri iletişimi yapıldı. parent/child şeklinde (@Input, @Output)<br />

# 4-error handling
  => Api'de http request pipeline'ına exception handler eklendi ve hata için response header düzenlendi<br />
  => Angular tarafında error interceptor eklendi, server response header'ına yanıtına göre client hata mesajını gösterebilir yapıldı
  
# 5-adding third party components
  => alertifyjs bildirim kütüphanesi angular servis olarak eklendi. <br />
  => angular JWT, (angular2-jwt) jwtHelper kullanılarak kullanıcı bilgiler token'dan decode edildi. app.component seviyesinde kullanıldı.<br />
  => ngx bootstrap kullanıldı. jquery olmaksızın bootstrap kullanımına olanak sağlar. (https://valor-software.com/ngx-bootstrap/?gclid=Cj0KCQiAoo7gBRDuARIsANeJKUZ0QnZPDDNlNa7NG8aHnn-c5-MRbLgnu90-ekriSP5LoQhcu_wPsSQaAoCyEALw_wcB#/dropdowns) <br />
  => bootswatch ile tema değişiklikliği uygulandı. (https://bootswatch.com/united/)

# 6-routers added
  => route guard eklendi. login olmadan bazı sayfalara erişim engellendi
