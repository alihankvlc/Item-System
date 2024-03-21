# Item-System
Oyunlarda kullandığım genel item yapısı bu şekilde.

Oyun içerisindeki tüm öğelerin ortak verilerini içeren bir temel veri sınıfı olan ItemData sınıfı oluşturulmuştur. Bu sınıf her öğe için gerekli olan ortak özellikleri içerir: (ID,name,description,icon) gibi. ItemData sınıfından türeyen alt sınıflar, belirli öğe türlerine özgü verileri tutabilir. Örneğin, silahlar gibi belirli öğeler bir ammo sayısına sahip olabilir. Bu durumda, silahlar için özel bir veri sınıfı olan WeaponData sınıfı oluşturulmuştur. WeaponData sınıfı, ItemData sınıfından miras alır ve silahların özel özelliklerini içerir. Örneğin tüfeklerin ve bıçakların farklı özelliklere sahip olabileceği göz önünde bulundurularak, WeaponData dan miras alan Melee ve Gun gibi alt sınıflar oluşturulmuştur. Bu alt sınıflar WeaponData sınıfından türetilir ve silahların özel özelliklerini tutar. Bu sayede, her öğe için gerekli olan ortak veriler ItemData sınıfında saklanırken belirli öğe türlerine özgü veriler alt sınıflarda saklanır ve bu sayede kodun daha okunabilir ve sürdürülebilir olması sağlanır.

https://github.com/alihankvlc/Item-System/assets/147824938/c04ce594-2e73-47a0-9bf8-d1a1a5d421c4


UPDATE.......!!!

https://github.com/alihankvlc/Item-System/assets/147824938/dc624b3a-7fce-444c-9c5b-09742edc971d




