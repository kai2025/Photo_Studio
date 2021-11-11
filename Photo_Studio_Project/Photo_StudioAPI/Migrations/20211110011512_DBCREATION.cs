using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Photo_StudioAPI.Migrations
{
    public partial class DBCREATION : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estado_Sesion",
                columns: table => new
                {
                    ID_Status = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripción_Status = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Estado_S__5AC2A7343C93B510", x => x.ID_Status);
                });

            migrationBuilder.CreateTable(
                name: "Fotos_Status",
                columns: table => new
                {
                    ID_Status = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fotos_Status", x => x.ID_Status);
                });

            migrationBuilder.CreateTable(
                name: "Tipo_Entrega",
                columns: table => new
                {
                    ID_Entrega = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo_Entrega", x => x.ID_Entrega);
                });

            migrationBuilder.CreateTable(
                name: "Tipo_SesionFotografica",
                columns: table => new
                {
                    ID_Tipo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripción_Sesion = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Costo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo_SesionFotografica", x => x.ID_Tipo);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    ID_User = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    passcode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.ID_User);
                });

            migrationBuilder.CreateTable(
                name: "Reserva",
                columns: table => new
                {
                    ID_Reserva = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Fecha_Hora = table.Column<DateTime>(type: "datetime", nullable: false),
                    Tipo_Sesion = table.Column<int>(type: "int", nullable: false),
                    Rev_status = table.Column<int>(type: "int", nullable: false),
                    Tipo_Entrega = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Reserva__C3B2553E2C25C68C", x => new { x.ID_Reserva, x.UserID });
                    table.ForeignKey(
                        name: "FK_Reserva_Tipo_Entrega",
                        column: x => x.Tipo_Entrega,
                        principalTable: "Tipo_Entrega",
                        principalColumn: "ID_Entrega",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reserva_Tipo_SesionFotografica",
                        column: x => x.Tipo_Sesion,
                        principalTable: "Tipo_SesionFotografica",
                        principalColumn: "ID_Tipo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reserva_Usuario1",
                        column: x => x.ID_Reserva,
                        principalTable: "Usuario",
                        principalColumn: "ID_User",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sesion",
                columns: table => new
                {
                    ID_Sesion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usuario_ID = table.Column<int>(type: "int", nullable: false),
                    Reserva_ID = table.Column<int>(type: "int", nullable: false),
                    Status_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Sesion__E1794C48EF2CFAB2", x => new { x.ID_Sesion, x.Reserva_ID, x.Usuario_ID });
                    table.ForeignKey(
                        name: "FK__Sesion__308E3499",
                        columns: x => new { x.Reserva_ID, x.Usuario_ID },
                        principalTable: "Reserva",
                        principalColumns: new[] { "ID_Reserva", "UserID" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Sesion__Status_I__00DF2177",
                        column: x => x.Status_ID,
                        principalTable: "Estado_Sesion",
                        principalColumn: "ID_Status",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sesion_Fotos_Status",
                        column: x => x.Status_ID,
                        principalTable: "Fotos_Status",
                        principalColumn: "ID_Status",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_Tipo_Entrega",
                table: "Reserva",
                column: "Tipo_Entrega");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_Tipo_Sesion",
                table: "Reserva",
                column: "Tipo_Sesion");

            migrationBuilder.CreateIndex(
                name: "IX_Sesion_Reserva_ID_Usuario_ID",
                table: "Sesion",
                columns: new[] { "Reserva_ID", "Usuario_ID" });

            migrationBuilder.CreateIndex(
                name: "IX_Sesion_Status_ID",
                table: "Sesion",
                column: "Status_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sesion");

            migrationBuilder.DropTable(
                name: "Reserva");

            migrationBuilder.DropTable(
                name: "Estado_Sesion");

            migrationBuilder.DropTable(
                name: "Fotos_Status");

            migrationBuilder.DropTable(
                name: "Tipo_Entrega");

            migrationBuilder.DropTable(
                name: "Tipo_SesionFotografica");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
