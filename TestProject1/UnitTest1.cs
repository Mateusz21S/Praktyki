using ConsoleApp4.Assests;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Player_Creation()
        {
            var player = new Player("Kaziu");

            Assert.Equal("Kaziu", player.Name);
            Assert.Equal(100, player.Health);
            Assert.True(player.IsAlive());
        }

        [Fact]
        public void Player_Takes_Damage_And_Health_Decreases()
        {
            var player = new Player("Kaziu");

            player.AddDamage(50);

            Assert.Equal(50, player.Health);
        }

        [Fact]
        public void Player_Attack_Deals_Damage()
        {
            var player = new Player("Kaziu");

            var damage = player.Attack();

            Assert.True(damage >= 0); 
           
        }

        
    }
}