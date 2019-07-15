using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Kanoon.Data.Migrations
{
    public partial class AddEntity_Heiat_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Heiat",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    EstablishedYear = table.Column<string>(nullable: true),
                    RegistrationNumber = table.Column<int>(nullable: false),
                    RegistrationLocation = table.Column<string>(nullable: true),
                    ManagerName = table.Column<string>(nullable: true),
                    ManagerPhoneNumber = table.Column<string>(nullable: true),
                    ContactPhoneNumber = table.Column<string>(nullable: true),
                    ContactNames = table.Column<string>(nullable: true),
                    MediaManagerFullName = table.Column<string>(nullable: true),
                    MediaManagerPhoneNumber = table.Column<string>(nullable: true),
                    IsLocal = table.Column<bool>(nullable: false),
                    IsEthnicity = table.Column<bool>(nullable: false),
                    IsGuild = table.Column<bool>(nullable: false),
                    IsOfficial = table.Column<bool>(nullable: false),
                    IsBreastplate = table.Column<bool>(nullable: false),
                    IsChainsaw = table.Column<bool>(nullable: false),
                    IsPassionReading = table.Column<bool>(nullable: false),
                    IsResemblance = table.Column<bool>(nullable: false),
                    AndOther = table.Column<string>(nullable: true),
                    IsWeekly = table.Column<bool>(nullable: false),
                    WeekDay = table.Column<string>(nullable: true),
                    IsMonthly = table.Column<bool>(nullable: false),
                    MonthDay = table.Column<string>(nullable: true),
                    IsYearly = table.Column<bool>(nullable: false),
                    YearDay = table.Column<string>(nullable: true),
                    IsDeally = table.Column<bool>(nullable: false),
                    IsQuran = table.Column<bool>(nullable: false),
                    IsPray = table.Column<bool>(nullable: false),
                    PrayName = table.Column<string>(nullable: true),
                    IsShokhanran = table.Column<bool>(nullable: false),
                    IsEagerness = table.Column<bool>(nullable: false),
                    IsCatering = table.Column<bool>(nullable: false),
                    AndOtherSchedule = table.Column<bool>(nullable: false),
                    SMSSystemNumber = table.Column<string>(nullable: true),
                    SiteAddress = table.Column<string>(nullable: true),
                    TelegramAddress = table.Column<string>(nullable: true),
                    InstagramAddress = table.Column<string>(nullable: true),
                    IsNotificationBar = table.Column<bool>(nullable: false),
                    Qhari = table.Column<string>(nullable: true),
                    Sokhanran = table.Column<string>(nullable: true),
                    Maddah = table.Column<string>(nullable: true),
                    SpecialApp = table.Column<string>(nullable: true),
                    Brothers = table.Column<bool>(nullable: false),
                    Sisters = table.Column<bool>(nullable: false),
                    ApproximatePopulation = table.Column<int>(nullable: false),
                    PopulationsInSpecialProgram = table.Column<int>(nullable: false),
                    Const = table.Column<bool>(nullable: false),
                    Mobile = table.Column<bool>(nullable: false),
                    Mosque = table.Column<bool>(nullable: false),
                    Husseinieh = table.Column<bool>(nullable: false),
                    PrivateBuilding = table.Column<bool>(nullable: false),
                    TemporaryPublicSpace = table.Column<bool>(nullable: false),
                    TotalArea = table.Column<int>(nullable: false),
                    TotalBrother = table.Column<int>(nullable: false),
                    TotalSister = table.Column<int>(nullable: false),
                    PopularSupport = table.Column<bool>(nullable: false),
                    FixedBudgetOrganizationOrOffice = table.Column<bool>(nullable: false),
                    EconomicActivitiesInTheField = table.Column<bool>(nullable: false),
                    TheCamp = table.Column<string>(nullable: true),
                    Cultural = table.Column<string>(nullable: true),
                    Educational = table.Column<string>(nullable: true),
                    Charity = table.Column<string>(nullable: true),
                    Others = table.Column<string>(nullable: true),
                    Area = table.Column<string>(nullable: true),
                    LocArea = table.Column<string>(nullable: true),
                    TheNeighbourhood = table.Column<string>(nullable: true),
                    TheMainStreet = table.Column<string>(nullable: true),
                    AuxiliaryRoad = table.Column<string>(nullable: true),
                    Alley = table.Column<string>(nullable: true),
                    Plaque = table.Column<string>(nullable: true),
                    EssentialRequirementsOfTheBoard = table.Column<string>(nullable: true),
                    LocationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heiat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Heiat_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Heiat_LocationId",
                table: "Heiat",
                column: "LocationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Heiat");
        }
    }
}
