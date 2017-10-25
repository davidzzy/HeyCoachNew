
public static class PlayerGeneration
{

	public static Player Center = new Player();
	public static Player PowerForward= new Player();
	public static Player SmallForward= new Player();
	public static Player ShootingGuard= new Player();
	public static Player PointGuard= new Player();


	public static void CenterGenerate(string type) 
	{
		if (type == "篮板机器"){
			ReboundMachine(Center);
		}

		if (type == "内线铁闸"){
			IronCenter(Center);
		}

		if (type == "身体男"){
			IronCenter(Center);
		}

		Center.position = 1;
	}

	public static void PowerForwardGenerate(string type) 
	{
		if (type == "高个投手"){
			TallShooter(PowerForward);
		}

		if (type == "低位怪兽"){
			PostMaster(PowerForward);
		}

		if (type == "身体男"){
			IronCenter(PowerForward);
			PowerForward.Name = "格里芬";
		}

		PowerForward.position = 2;
	}

	public static void SmallForwardGenerate(string type) 
	{
		if (type == "全能小前"){
			AllAround(SmallForward);
		}

		if (type == "突击手"){
			Driver(SmallForward);
		}

		if (type == "炮台"){
			Shooter(SmallForward);
		}

		SmallForward.position = 3;
	}

	public static void ShootingGuardGenerate(string type) 
	{
		if (type == "牛皮糖"){
			AnchorMan(ShootingGuard);
		}

		if (type == "突击手"){
			Driver(ShootingGuard);
			ShootingGuard.Name = "德罗赞";
		}

		if (type == "炮台"){
			Shooter(ShootingGuard);
			ShootingGuard.Name = "汤普森";
		}

		ShootingGuard.position = 4;
	}


	public static void PointGuardGenerate(string type) 
	{
		if (type == "牛皮糖"){
			AnchorMan(PointGuard);
			PointGuard.Name = "贝弗利";
		}

		if (type == "双能卫"){
			ComboGuard(PointGuard);

		}

		if (type == "控场大师"){
			TextBook(PointGuard);

		}

		ShootingGuard.position = 4;
	}

	public static void ReboundMachine(Player player){
		player.Name = "小乔丹";
		player.speed=60;
		player.strenth=90;
		player.jumping=80;
		player.stamina=80;
		player.fitness=90;
		player.rebound=90;
		player.dribble=40;
		player.shooting=60;
		player.pass=40;
		player.defense=60;

		player.fouls = 0;
	}

	public static void IronCenter(Player player){
		player.Name = "戈贝尔";
		player.speed=70;
		player.strenth=80;
		player.jumping=90;
		player.stamina=90;
		player.fitness=90;
		player.rebound=80;
		player.dribble=40;
		player.shooting=50;
		player.pass=40;
		player.defense=90;

		player.fouls = 0;
	}

	public static void Athletic(Player player){
		player.Name = "怀特塞德";
		player.speed=80;
		player.strenth = 90;
		player.jumping=90;
		player.stamina=90;
		player.fitness=90;
		player.rebound=80;
		player.dribble=40;
		player.shooting=40;
		player.pass=40;
		player.defense=60;

		player.fouls = 0;
	}

	public static void TallShooter(Player player){
		player.Name = "诺维茨基";
		player.speed=60;
		player.strenth = 70;
		player.jumping=50;
		player.stamina=70;
		player.fitness=80;
		player.rebound=70;
		player.dribble=70;
		player.shooting=90;
		player.pass=60;
		player.defense=60;

		player.fouls = 0;
	}

	public static void PostMaster(Player player){
		player.Name = "邓肯";
		player.speed=70;
		player.strenth = 80;
		player.jumping=70;
		player.stamina=70;
		player.fitness=70;
		player.rebound=70;
		player.dribble=70;
		player.shooting=80;
		player.pass=60;
		player.defense=70;

		player.fouls = 0;
	}

	public static void AllAround(Player player){
		player.Name = "莱纳德";
		player.speed=80;
		player.strenth = 80;
		player.jumping=80;
		player.stamina=80;
		player.fitness=80;
		player.rebound=60;
		player.dribble=80;
		player.shooting=70;
		player.pass=70;
		player.defense=70;

		player.fouls = 0;
	}

	public static void Driver(Player player){
		player.Name = "詹姆斯";
		player.speed=80;
		player.strenth = 60;
		player.jumping=70;
		player.stamina=80;
		player.fitness=70;
		player.rebound=60;
		player.dribble=90;
		player.shooting=80;
		player.pass=60;
		player.defense=60;

		player.fouls = 0;
	}

	public static void Shooter(Player player){
		player.Name = "杜兰特";
		player.speed=70;
		player.strenth = 60;
		player.jumping=60;
		player.stamina=70;
		player.fitness=70;
		player.rebound=60;
		player.dribble=70;
		player.shooting=90;
		player.pass=70;
		player.defense=70;

		player.fouls = 0;
	}


	public static void AnchorMan(Player player){
		player.Name = "托尼阿伦";
		player.speed=80;
		player.strenth = 70;
		player.jumping=60;
		player.stamina=80;
		player.fitness=90;
		player.rebound=60;
		player.dribble=60;
		player.shooting=70;
		player.pass=70;
		player.defense=90;

		player.fouls = 0;
	}

	public static void ComboGuard(Player player){
		player.Name = "维斯布鲁克";
		player.speed=80;
		player.strenth = 70;
		player.jumping=80;
		player.stamina=80;
		player.fitness=80;
		player.rebound=30;
		player.dribble=80;
		player.shooting=80;
		player.pass=80;
		player.defense=60;

		player.fouls = 0;
	}

	public static void TextBook(Player player){
		player.Name = "保罗";
		player.speed=80;
		player.strenth = 60;
		player.jumping=70;
		player.stamina=80;
		player.fitness=80;
		player.rebound=40;
		player.dribble=90;
		player.shooting=80;
		player.pass=90;
		player.defense=70;

		player.fouls = 0;
	}
}