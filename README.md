# dotnetcoreAndAngularDemo
course on udemy => Build an app with ASPNET Core and Angular from scratch 

# 1-initial commit
  => dotnet webapi oluşturuldu <br />
  => dotnet new webapi -o DatingApp.API -n DatingApp.API
  => vs code extension'ları kuruldu
  => ControllerBase, MVC controller without view support | Controller, MVC controller with view support and advantage of the auto binding
  => [ApiController] kullanılan controller için 'Automatic model state validation' ve 'Automatic inferring of parameter binding' ([FromBody] kullanıma gerek kalmıyor). Ayrıca ApiControllerAttribute oldukça esnek şekilde customize edilebiliyor. İstenilen özellikler enable-disable edilebiliyor. (ApiBehaviorOptions)
  => dotnet run - dotnet watch run
  => CodeFirst db oluşturuldu. DbContext'ten kalıtım alarak entityler oluşturuldu. ConfigureServices metoduna DbContext eklendi. (dotnet ef migrations add MigrationName) (dotnet ef database update)
  => angular projesi @angular/cli ile oluşturuldu. (ng new DatingApp-SPA)
  => ng serve ile client yayınlandı

# 2-authController added
  => Password şifreli bir şekilde jwt kullanılarak db ye kayıt edilir yapıldı.
  => Repository pattern implemente edildi
  => Register, login metodları yazıldı
  => Authentication middleware oluşturuldu. 
  
# 3-client side login register
  => Bootstap kullanılarak navbar oluşturuldu. (https://getbootstrap.com/docs/4.1/examples/)
  => Template form kullanıldı ve input/form state'leri incelendi. *ngIf, *ngFor kullanıldı
  => Angular servisleri kullanıldı 
  => Komponentler arası veri iletişimi yapıldı. parent/child şeklinde (@Input, @Output)
