using ConsoleApp4.Assests;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Player_Creation() {
            var player = new Player("Kaziu");


            Assert.Equal(player.Name, "Kaziu");
            Assert.Equal(player.Health, 100);
            Assert.True(player.IsAlive());
        }

        [Fact]
        public void Add_Damage_Test() {
            //arrange
            var player = new Player("Kaziu");
            //act
            player.AddDamage(50);   

            //assert
            Assert.Equal(player.Health, 50);

        }
        
        //test pozosta³em rzeczy czy ¿yje itp



    }
}