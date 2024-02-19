﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MycoMatrix.Models;

#nullable disable

namespace MycoMatrix.Migrations
{
    [DbContext(typeof(MycoMatrixContext))]
    partial class MycoMatrixContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MycoMatrix.Models.Mushroom", b =>
                {
                    b.Property<int>("MushroomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CommonName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Genus")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("GillType")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ImageURL")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Notes")
                        .HasColumnType("longtext");

                    b.Property<string>("Species")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<int>("ToxicityLevel")
                        .HasColumnType("int");

                    b.HasKey("MushroomId");

                    b.ToTable("Mushrooms");

                    b.HasData(
                        new
                        {
                            MushroomId = 1,
                            CommonName = "Black Trumpet",
                            Genus = "Craterellus",
                            GillType = "Ridged",
                            ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b7/Craterellus_cornucopioides_Eestis.JPG/800px-Craterellus_cornucopioides_Eestis.JPG",
                            Notes = "choice edible, grows under oak and beech trees",
                            Species = "cornucopioides",
                            ToxicityLevel = 0
                        },
                        new
                        {
                            MushroomId = 2,
                            CommonName = "Golden Chanterelle",
                            Genus = "Cantharellus",
                            GillType = "Ridged",
                            ImageURL = "https://d2ci82p1s8eczl.cloudfront.net/wp-content/uploads/20231219151006/castatemushroom-scaled.jpg",
                            Notes = "choice edible, grows in conifer forests under Douglas Fir, spruce and hemlocks",
                            Species = "cibarius",
                            ToxicityLevel = 0
                        },
                        new
                        {
                            MushroomId = 3,
                            CommonName = "Morel",
                            Genus = "Morchella",
                            GillType = "None",
                            ImageURL = "https://media.istockphoto.com/id/1059075136/photo/a-large-group-of-morels-by-a-stream.jpg?s=612x612&w=0&k=20&c=QU-hajnz7xC60AGuQhsJWOAx7MpVB4sWbMB0xEE3vVI=",
                            Notes = "may cause some stomach upset in certain individuals, must cook thoroughly",
                            Species = "esculenta",
                            ToxicityLevel = 3
                        },
                        new
                        {
                            MushroomId = 4,
                            CommonName = "Chicken of the woods",
                            Genus = "Laetiporus",
                            GillType = "Polypore",
                            ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8b/Laetiporus_sulphureus_JPG01.jpg/1920px-Laetiporus_sulphureus_JPG01.jpg",
                            Notes = "may cause some GI upset in some individuals, grows on dead or dying trees",
                            Species = "sulphureus",
                            ToxicityLevel = 3
                        },
                        new
                        {
                            MushroomId = 5,
                            CommonName = "Black Trumpet",
                            Genus = "Craterellus",
                            GillType = "Ridged",
                            ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b7/Craterellus_cornucopioides_Eestis.JPG/800px-Craterellus_cornucopioides_Eestis.JPG",
                            Notes = "choice edible, grows under oak and beech trees",
                            Species = "cornucopioides",
                            ToxicityLevel = 0
                        },
                        new
                        {
                            MushroomId = 6,
                            CommonName = "Deadly Galerina",
                            Genus = "Galerina",
                            GillType = "Gills",
                            ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b7/Craterellus_cornucopioides_Eestis.JPG/800px-Craterellus_cornucopioides_Eestis.JPG",
                            Notes = "contains amatoxins, has been confused with Psilocybe stuntzii",
                            Species = "marginata",
                            ToxicityLevel = 10
                        },
                        new
                        {
                            MushroomId = 7,
                            CommonName = "Fly Agaric",
                            Genus = "Amanita",
                            GillType = "Gills",
                            ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/32/Amanita_muscaria_3_vliegenzwammen_op_rij.jpg/1920px-Amanita_muscaria_3_vliegenzwammen_op_rij.jpg",
                            Notes = "won't kill you",
                            Species = "muscaria",
                            ToxicityLevel = 5
                        },
                        new
                        {
                            MushroomId = 8,
                            CommonName = "toxic black mold",
                            Genus = "Stachybotrys",
                            GillType = "None",
                            ImageURL = "https://upload.wikimedia.org/wikipedia/commons/7/7c/2009-05-09_Stachybotrys_chartarum_%28Ehrenb.%29_S._Hughes_43158.jpg",
                            Notes = "One of the worst fungi to encounter",
                            Species = "chartarum",
                            ToxicityLevel = 8
                        },
                        new
                        {
                            MushroomId = 9,
                            CommonName = "Turkey Tail",
                            Genus = "Trametes",
                            GillType = "Pores",
                            ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a3/Trametes_versicolor_G4_%281%29.JPG/1280px-Trametes_versicolor_G4_%281%29.JPG",
                            Notes = "edible, medicinal",
                            Species = "versicolor",
                            ToxicityLevel = 0
                        },
                        new
                        {
                            MushroomId = 10,
                            CommonName = "Crystal Brain",
                            Genus = "Myxarium",
                            GillType = "None",
                            ImageURL = "https://upload.wikimedia.org/wikipedia/commons/9/95/Crystal_Brain_Fungus_%28Exidia_nucleata%29_-_geograph.org.uk_-_1000447.jpg",
                            Notes = "Unknown if edible or not",
                            Species = "nucleatum",
                            ToxicityLevel = 0
                        },
                        new
                        {
                            MushroomId = 11,
                            CommonName = "Magic Mushrooms",
                            Genus = "Psilocybe",
                            GillType = "Gills",
                            ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7f/Cubensis_Xalapa.jpg/1280px-Cubensis_Xalapa.jpg",
                            Notes = "The classic tripper's delight",
                            Species = "cubensis",
                            ToxicityLevel = 2
                        },
                        new
                        {
                            MushroomId = 12,
                            CommonName = "Cordyceps",
                            Genus = "Ophiocordyceps ",
                            GillType = "None",
                            ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/85/Ophiocordyceps_unilateralis.png/800px-Ophiocordyceps_unilateralis.png",
                            Notes = "If you're an ant it's bad news, otherwise it's medicinal",
                            Species = "unilateralis",
                            ToxicityLevel = 2
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
