using Xunit;

namespace Parrot.Tests
{
    public class ParrotTest
    {
        [Fact]
        public void GetSpeedNorwegianBlueParrot_nailed()
        {
            var parrot = new Parrot(ParrotTypeEnum.NORWEGIAN_BLUE, 0, 0, true);
            Assert.Equal(0.0, parrot.GetSpeed());
        }

        [Fact]
        public void GetSpeedNorwegianBlueParrot_not_nailed()
        {
            var parrot = new Parrot(ParrotTypeEnum.NORWEGIAN_BLUE, 0, 1.5, false);
            Assert.Equal(18.0, parrot.GetSpeed());
        }

        [Fact]
        public void GetSpeedNorwegianBlueParrot_not_nailed_high_voltage()
        {
            var parrot = new Parrot(ParrotTypeEnum.NORWEGIAN_BLUE, 0, 4, false);
            Assert.Equal(24.0, parrot.GetSpeed());
        }

        [Fact]
        public void GetSpeedOfAfricanParrot_With_No_Coconuts()
        {
            Parrot parrot = new Parrot(ParrotTypeEnum.AFRICAN, 0, 0, false);
            Assert.Equal(12.0, parrot.GetSpeed());
            AfricanParrot africanParrot = new AfricanParrot(0);
            Assert.Equal(12.0, africanParrot.GetSpeed());

        }

        [Fact]
        public void GetSpeedOfAfricanParrot_With_One_Coconut()
        {
            Parrot parrot = new Parrot(ParrotTypeEnum.AFRICAN, 1, 0, false);
            Assert.Equal(3.0, parrot.GetSpeed());
            AfricanParrot africanParrot = new AfricanParrot(1);
            Assert.Equal(3.0, africanParrot.GetSpeed());
        }

        [Fact]
        public void GetSpeedOfAfricanParrot_With_Two_Coconuts()
        {
            var parrot = new Parrot(ParrotTypeEnum.AFRICAN, 2, 0, false);
            Assert.Equal(0.0, parrot.GetSpeed());
            AfricanParrot africanParrot = new AfricanParrot(2);
            Assert.Equal(0.0, africanParrot.GetSpeed());
        }

        [Fact]
        public void GetSpeedOfEuropeanParrot()
        {
            var parrot = new Parrot(ParrotTypeEnum.EUROPEAN, 0, 0, false);
            Assert.Equal(12.0, parrot.GetSpeed());
        }

        [Fact]
        public void GetCryOfEuropeanParrot()
        {
            var parrot = new Parrot(ParrotTypeEnum.EUROPEAN, 0, 0, false);
            Assert.Equal("Sqoork!", parrot.GetCry());
        }

        [Fact]
        public void GetCryOfAfricanParrot()
        {
            Parrot parrot = new Parrot(ParrotTypeEnum.AFRICAN, 2, 0, false);
            Assert.Equal("Sqaark!", parrot.GetCry());
            AfricanParrot africanParrot = new AfricanParrot(2);
            Assert.Equal("Sqaark!", africanParrot.GetCry());

        }

        [Fact]
        public void GetCryNorwegianBlueParrot_high_voltage()
        {
            var parrot = new Parrot(ParrotTypeEnum.NORWEGIAN_BLUE, 0, 4, false);
            Assert.Equal("Bzzzzzz", parrot.GetCry());
        }

        [Fact]
        public void GetCryNorwegianBlueParrot_no_voltage()
        {
            var parrot = new Parrot(ParrotTypeEnum.NORWEGIAN_BLUE, 0, 0, false);
            Assert.Equal("...", parrot.GetCry());
        }
    }
}