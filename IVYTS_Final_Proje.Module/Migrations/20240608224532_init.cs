using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IVYTS_Final_Proje.Module.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OneHotEncodedCarData",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Car_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Selling_Price = table.Column<float>(type: "real", nullable: false),
                    Present_Price = table.Column<float>(type: "real", nullable: false),
                    Kms_Driven = table.Column<float>(type: "real", nullable: false),
                    Owner = table.Column<int>(type: "int", nullable: false),
                    Fuel_Type_Diesel = table.Column<bool>(type: "bit", nullable: false),
                    Fuel_Type_Petrol = table.Column<bool>(type: "bit", nullable: false),
                    Seller_Type_Individual = table.Column<bool>(type: "bit", nullable: false),
                    Transmission_Manual = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OneHotEncodedCarData", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "OriginalCarData",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Car_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Selling_Price = table.Column<float>(type: "real", nullable: false),
                    Present_Price = table.Column<float>(type: "real", nullable: false),
                    Kms_Driven = table.Column<float>(type: "real", nullable: false),
                    Fuel_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Seller_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Transmission = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Owner = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OriginalCarData", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Random_Data",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Present_Price = table.Column<float>(type: "real", nullable: false),
                    Kms_Driven = table.Column<float>(type: "real", nullable: false),
                    Owner = table.Column<int>(type: "int", nullable: false),
                    Fuel_Type_Diesel = table.Column<bool>(type: "bit", nullable: false),
                    Fuel_Type_Petrol = table.Column<bool>(type: "bit", nullable: false),
                    Seller_Type_Individual = table.Column<bool>(type: "bit", nullable: false),
                    Transmission_Manual = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Random_Data", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Random_Data_Prediction",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Selling_Price = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Random_Data_Prediction", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Random_Data_Scaled",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Year = table.Column<float>(type: "real", nullable: false),
                    Present_Price = table.Column<float>(type: "real", nullable: false),
                    Kms_Driven = table.Column<float>(type: "real", nullable: false),
                    Owner = table.Column<float>(type: "real", nullable: false),
                    Fuel_Type_Diesel = table.Column<float>(type: "real", nullable: false),
                    Fuel_Type_Petrol = table.Column<float>(type: "real", nullable: false),
                    Seller_Type_Individual = table.Column<float>(type: "real", nullable: false),
                    Transmission_Manual = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Random_Data_Scaled", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Test_Prediction",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Selling_Price = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Test_Prediction", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Trained_Prediction",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Selling_Price = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trained_Prediction", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "X_Test",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Present_Price = table.Column<float>(type: "real", nullable: false),
                    Kms_Driven = table.Column<float>(type: "real", nullable: false),
                    Owner = table.Column<int>(type: "int", nullable: false),
                    Fuel_Type_Diesel = table.Column<bool>(type: "bit", nullable: false),
                    Fuel_Type_Petrol = table.Column<bool>(type: "bit", nullable: false),
                    Seller_Type_Individual = table.Column<bool>(type: "bit", nullable: false),
                    Transmission_Manual = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_X_Test", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "X_Test_Scaled",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Year = table.Column<float>(type: "real", nullable: false),
                    Present_Price = table.Column<float>(type: "real", nullable: false),
                    Kms_Driven = table.Column<float>(type: "real", nullable: false),
                    Owner = table.Column<float>(type: "real", nullable: false),
                    Fuel_Type_Diesel = table.Column<float>(type: "real", nullable: false),
                    Fuel_Type_Petrol = table.Column<float>(type: "real", nullable: false),
                    Seller_Type_Individual = table.Column<float>(type: "real", nullable: false),
                    Transmission_Manual = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_X_Test_Scaled", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "X_Train",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Present_Price = table.Column<float>(type: "real", nullable: false),
                    Kms_Driven = table.Column<float>(type: "real", nullable: false),
                    Owner = table.Column<int>(type: "int", nullable: false),
                    Fuel_Type_Diesel = table.Column<bool>(type: "bit", nullable: false),
                    Fuel_Type_Petrol = table.Column<bool>(type: "bit", nullable: false),
                    Seller_Type_Individual = table.Column<bool>(type: "bit", nullable: false),
                    Transmission_Manual = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_X_Train", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "X_Train_Scaled",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Year = table.Column<float>(type: "real", nullable: false),
                    Present_Price = table.Column<float>(type: "real", nullable: false),
                    Kms_Driven = table.Column<float>(type: "real", nullable: false),
                    Owner = table.Column<float>(type: "real", nullable: false),
                    Fuel_Type_Diesel = table.Column<float>(type: "real", nullable: false),
                    Fuel_Type_Petrol = table.Column<float>(type: "real", nullable: false),
                    Seller_Type_Individual = table.Column<float>(type: "real", nullable: false),
                    Transmission_Manual = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_X_Train_Scaled", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Y_Test",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Selling_Price = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Y_Test", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Y_Train",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Selling_Price = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Y_Train", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OneHotEncodedCarData");

            migrationBuilder.DropTable(
                name: "OriginalCarData");

            migrationBuilder.DropTable(
                name: "Random_Data");

            migrationBuilder.DropTable(
                name: "Random_Data_Prediction");

            migrationBuilder.DropTable(
                name: "Random_Data_Scaled");

            migrationBuilder.DropTable(
                name: "Test_Prediction");

            migrationBuilder.DropTable(
                name: "Trained_Prediction");

            migrationBuilder.DropTable(
                name: "X_Test");

            migrationBuilder.DropTable(
                name: "X_Test_Scaled");

            migrationBuilder.DropTable(
                name: "X_Train");

            migrationBuilder.DropTable(
                name: "X_Train_Scaled");

            migrationBuilder.DropTable(
                name: "Y_Test");

            migrationBuilder.DropTable(
                name: "Y_Train");
        }
    }
}
