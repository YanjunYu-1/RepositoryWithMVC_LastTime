一、在Model中创建Class：Account和Customer

二、建立连接：视图=>服务器资源管理器（可有可无，此次省略此操作）

三、建立controller

（1）安装依赖包
```java
Install-Package Microsoft.VisualStudio.Web.CodeGeneration.Design
```

（2）建立Account和Customer的controller
```java
~/Views/Shared/_Layout.cshtml
```

（3）在appsettings中连接服务器

（4）迁移并上传SQL
```java
Add-Migration Initial
Update-Database

Remove-Migration
```

四、完成SeedData

（1）建立class=>SeedData=>以下代码照抄

```java
var context = new RepositoryWithMVC_LastTimeContext$$Data里面的Context$$(serviceProvider.GetRequiredService<DbContextOptions<RepositoryWithMVC_LastTimeContext$$Data里面的Context$$>>());
```

(2)每次数据变化Id都会变化，因此Id不能是定值，否则第一次运行时，数据可以进入数据库，但是删除之后再次运行，Id发生变化，数据也就无法进入，系统报错。

（3）program中以下代码照抄

```java
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    await SeedData.Initialize(services);
}
```

（4）注意：通过测试，所有的数据都可以在此添加，但是注意需要先建主键信息，然后再减外键信息，但是不明白为什么第一次seedData成功，删除数据后再次运行就失败。

五、建立DAL和BLL

（1）DAL：建立接口，利用泛型把所有功能写入=>建立对每个class的DAL文件，将泛型功能接入。

（2）BLL：对每个Class写BLL文件，一旦建立BLL文件，需要对controller文件进行修改，因为所有数据来源的位置进行了改变

注意：BLL层调取DAL层数据，然后数据在controller中进行实现，此处用了两种方法，都可以提取数据