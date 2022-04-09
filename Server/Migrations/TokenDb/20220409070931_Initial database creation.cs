﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace codedash.Server.Migrations.TokenDb
{
    public partial class Initialdatabasecreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Token",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    TokenString = table.Column<string>(type: "TEXT", nullable: true),
                    UsernameHash = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Token", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Token",
                columns: new[] { "Id", "TokenString", "UsernameHash" },
                values: new object[] { new Guid("27e8e8bf-6883-4883-9dd5-b20fe49626da"), "+)5cuSey@ewEuepRm\\Sv.Rn|l@3#+eNx\"2w6I_D7$|*D%[dZRO*55v~=r'~6TKKFdlxcOgo*I+}afpq^/d99DHg{<p*s4;Nw|o*o\"Li:;CD{J,'5P(x|}j64b7_.4\"J|_opmPa+lU+^!e|m;6?sO3vp/$/'%tyL}v!3Zg,B^DBK\\p&'WC,esDmWAGB4TEa(![6gbF0K3,N&(~&#|\"Nx-PgJk\"DlL$iQO*RgUHN(F=1EuUg}uBq1V0YvVytRyr&i,B[stBqKPZy?,C|pWQ?qY*')t[w|mC+;sbt6{KD$p$K<grlQ7j9*^==D:M5z-LqQgmd+xU(X$Og^GcZD]_2cI]Npp1_ez7V6`mJKcRWG_*Sy]2fc`&WI%-)NL90-9\\\\s,}+Lhh6Z\"0.6`TuMcz.>6x?t,YpvHwK'7VdDZSvI+ntf''y).Q':ki1:rKy%,N`-v*q3L1;r}WCk^>uph{)V5i_Fxl&Q,tV!-xCYgA,%!5Clrvq/4L04coRg#o]hei_Qw", "3a2bdfc8841a6b57e71e90983ccd34cd7c8950d2d59506c9df7565978d1891ab11c7c2fc8948d1109eb098e8d016e2d4999a404d0e15ae0ce5637b0482446c0e" });

            migrationBuilder.InsertData(
                table: "Token",
                columns: new[] { "Id", "TokenString", "UsernameHash" },
                values: new object[] { new Guid("606682d6-e70a-45d3-aa8b-def75d2cf4d8"), "Ey$twN@?5R|<\"zL|F]f)#IuJ:_A|US;&30)|${7*H*s_gY)Z-o`t6AhA?GNa!uf`-#6*pUc-1v5n|:hHb5|r\"%s-,[SWNv=;hpK/'V%S#|I\"uTY8~/\\oI>3\\[&N+l'tEFKwWo^%X[WR#g=OeGr+@ehG6w17@liYPa~,{lMP`]7apNlK(7)@/k~e,c;~VSeOj:Q}z5rY-8:W!my2Fwaok~cS:8UlR>0&c:U@%;y[AqNk3Yn&d4qP(Vq./a60>l8dSA^[YkR6{MAox'j'/,t+l{8Ws,6Im1{}Sq]P}1ru<NqQL~Di-fgS.?^+P^z=.5?'he<>8r&^bJ/g3/7a%3PQ'59x_Z`?9)S8x?u=$DN-)/#Dup7esT8Z>Dcs4$Q3Ad^Vt>AI0)^z!kNRQ*aG\"n)R-%A.q^N}g({euMD1[z2~73MUIznvzR/rv+Uj+:SYf`-Wt4f1n)c<w\\|c}}Xc$]i%R3L-tk3|ADw&Pz|Y&zXZiu0$B>::&>NO&>e@[cXyE5:J@", "4a2bdfc8841a6b57e71e90983ccd34cd7c8950d2d59506c9df7565978d1891ab11c7c2fc8948d1109eb098e8d016e2d4999a404d0e15ae0ce5637b0482446c0e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Token");
        }
    }
}
