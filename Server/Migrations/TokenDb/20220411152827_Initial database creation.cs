﻿using Microsoft.EntityFrameworkCore.Migrations;

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
                    Id = table.Column<string>(type: "TEXT", nullable: false),
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
                values: new object[] { "082bbe49-0d2b-4451-abc1-f487bff55dc7", "?=yZ?;9\\RGRXy>Ng'38Bg_X2ne_&#z(gSUDuNsA?FvfzvRIMFE0:c2\"t\\5:nCsC!$Ml#;&#[QM_O,5x\\J\\&cq<]zw%!3R'(^6MT0^!U?#Z:yPz08|D&ku)V#m@Ey{=M+Hn+_e=mepH|TrA[+_wihs;#o7?N=R+)@Kk;yET/{UD0W2[$Dbm7}?~(gzcR>i)Uwg+D#~JL)Vf[ay\"H;;]wm]8IAjG<^l<VO%5&iQNy!?YZ3fX:W4!U)t`6XDS6YWaw_qZ!{Y'Cd;(lB\\Ay}`2OSQW%.P[~uX^(Zt<GtbeYhzfs#kH&-Rwe7JjQY48.zd?c5<Vc+9@@k~LnoOZ;o;RO0|ou:N#pTzsQ>`(G,m'McbQ\"dQPw?j{,iQu]#Y5m8_#++OU9)HAD4K5PO;p3h=&8,'ME_Q^)/U$V)oe;>-rb33X&yl|Gwtu'lf'?GC(Rc@)S-%ZL+e)V>M5fx|D4S6oG{#GK\"cAZ\"R0^J0Jn0;w99gaMNpD\\6{*r-5<-059\\`/QQE", "3a2bdfc8841a6b57e71e90983ccd34cd7c8950d2d59506c9df7565978d1891ab11c7c2fc8948d1109eb098e8d016e2d4999a404d0e15ae0ce5637b0482446c0e" });

            migrationBuilder.InsertData(
                table: "Token",
                columns: new[] { "Id", "TokenString", "UsernameHash" },
                values: new object[] { "f97c0a84-1d24-4981-967c-28f57d506913", "Nn;dI/C=}g2nGO@&[i_c3hlF2_Th!Ig&4Y}Hepmlg1w}Z{vyFO{SG&'Vv[+M1mV2u5:.u9jLFUCiHq5}fo\"$S[xNHQ#4\"s.D/J>i\\AnR5+AJ]eH_uO!@b4p)/?B_Cn;1E#s^3rkPY`0ALxHbe9h;7'3sd'e!o8SfMBjLIoWU]HvB!Nak(^dxW<=fDqo/Ys[i8wQ35oSmjc\"X0>Ow.s<YtB9HvUKeXr_eeDa?6^EygTUC:E4qJ-unS=v5\\gl;(cSz>amyN*CxRzZ0#Xm~\\AT'H}O7w~Pa|Ig+_vUk]o\"0w<lJs^H#`@FFZ<&{*jtaoC;~@B.~!O7L)W9LBJ+By9=\"ZJvCnk)*@\"d/YY#j$GToH(]i6Sg%i.<_YG[&@B,>Z_4V,@LJ!BsI48<D[-?DAM)[C?JmVFxo^B:7eti@-{ip;h6SW-aj>am]t+k>Y0[tg<Hgnf^';wBFdgbg<\\P#:.RtZ]|ieI$!'VozsDQIIj_vpB;s/|m&n9^5.|6)4)fyBVQ_", "4a2bdfc8841a6b57e71e90983ccd34cd7c8950d2d59506c9df7565978d1891ab11c7c2fc8948d1109eb098e8d016e2d4999a404d0e15ae0ce5637b0482446c0e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Token");
        }
    }
}
