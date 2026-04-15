using Marten.Schema;

namespace Catalog.API.Data;

public class CatalogInitialData : IInitialData
{
    public async Task Populate(IDocumentStore store, CancellationToken cancellation)
    {
        using var session = store.LightweightSession();

        if(await session.Query<Product>().AnyAsync())
            return;

        
        session.Store<Product>(GetPreconfiguredProducts());

        await session.SaveChangesAsync(cancellation);
    }

    private static IEnumerable<Product> GetPreconfiguredProducts() => new List<Product>() {
        new Product()
        {
            Id = new Guid("5334c996-8457-4cf0-815c-ed2b77c4ff61"),
            Name = "IPhone X",
            Description = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
            ImageFile = "product-1.png",
            Price = 950.00M,
            Category = new List<string> { "Smart Phone" }
        },
        new Product()
        {
            Id = new Guid("c67d6323-e8b1-4bdf-9a75-b0d0d2e7e914"),
            Name = "Samsung 10",
            Description = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
            ImageFile = "product-2.png",
            Price = 840.00M,
            Category = new List<string> { "Smart Phone" }
        },
        new Product()
        {
            Id = new Guid("4f136e9f-ff8c-4c1f-9a33-d12f689bdab8"),
            Name = "Huawei Plus",
            Description = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
            ImageFile = "product-3.png",
            Price = 650.00M,
            Category = new List<string> { "White Appliances" }
        },
        new Product()
        {
            Id = new Guid("6ec1297b-ec0a-4aa1-be25-6726e3b51a27"),
            Name = "Xiaomi Mi 9",
            Description = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
            ImageFile = "product-4.png",
            Price = 470.00M,
            Category = new List<string> { "White Appliances" }
        },
        new Product()
        {
            Id = new Guid("b786103d-c621-4f5a-b498-23452610f88c"),
            Name = "HTC U11+ Plus",
            Description = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
            ImageFile = "product-5.png",
            Price = 380.00M,
            Category = new List<string> { "Smart Phone" }
        },
        new Product()
        {
            Id = new Guid("c4bbc4a2-4555-45d8-97cc-2a99b2167bff"),
            Name = "LG G7 ThinQ",
            Description = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
            ImageFile = "product-6.png",
            Price = 240.00M,
            Category = new List<string> { "Home Kitchen" }
        },
        new Product()
        {
            Id = new Guid("93170c85-7795-489c-8e8f-7dcf3b4f4188"),
            Name = "Panasonic Lumix",
            Description = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
            ImageFile = "product-6.png",
            Price = 240.00M,
            Category = new List<string> { "Camera" }
        },
        // SMART PHONES (10)
        new Product { Id = Guid.NewGuid(), Name = "iPhone 14 Pro", Description = "Apple flagship smartphone with A16 chip.", ImageFile = "p1.png", Price = 1099M, Category = new List<string>{ "Smart Phone" } },
        new Product { Id = Guid.NewGuid(), Name = "Samsung Galaxy S23", Description = "Premium Android smartphone with Snapdragon processor.", ImageFile = "p2.png", Price = 999M, Category = new List<string>{ "Smart Phone" } },
        new Product { Id = Guid.NewGuid(), Name = "Google Pixel 8", Description = "AI-powered smartphone with excellent camera.", ImageFile = "p3.png", Price = 899M, Category = new List<string>{ "Smart Phone" } },
        new Product { Id = Guid.NewGuid(), Name = "OnePlus 11", Description = "Fast and smooth smartphone with OxygenOS.", ImageFile = "p4.png", Price = 799M, Category = new List<string>{ "Smart Phone" } },
        new Product { Id = Guid.NewGuid(), Name = "Xiaomi Mi 13", Description = "Affordable flagship with great performance.", ImageFile = "p5.png", Price = 699M, Category = new List<string>{ "Smart Phone" } },
        new Product { Id = Guid.NewGuid(), Name = "Huawei P60", Description = "Elegant design with powerful camera system.", ImageFile = "p6.png", Price = 850M, Category = new List<string>{ "Smart Phone" } },
        new Product { Id = Guid.NewGuid(), Name = "Motorola Edge 40", Description = "Sleek design and clean Android experience.", ImageFile = "p7.png", Price = 650M, Category = new List<string>{ "Smart Phone" } },
        new Product { Id = Guid.NewGuid(), Name = "Sony Xperia 5", Description = "Compact flagship with cinematic display.", ImageFile = "p8.png", Price = 899M, Category = new List<string>{ "Smart Phone" } },
        new Product { Id = Guid.NewGuid(), Name = "Nokia X30", Description = "Durable and eco-friendly smartphone.", ImageFile = "p9.png", Price = 499M, Category = new List<string>{ "Smart Phone" } },
        new Product { Id = Guid.NewGuid(), Name = "Asus ROG Phone 7", Description = "Gaming smartphone with high refresh rate.", ImageFile = "p10.png", Price = 999M, Category = new List<string>{ "Smart Phone", "Gaming" } },

        // LAPTOPS (10)
        new Product { Id = Guid.NewGuid(), Name = "MacBook Air M2", Description = "Lightweight laptop with Apple silicon.", ImageFile = "p11.png", Price = 1199M, Category = new List<string>{ "Laptop", "Computers" } },
        new Product { Id = Guid.NewGuid(), Name = "Dell XPS 15", Description = "High-performance ultrabook.", ImageFile = "p12.png", Price = 1499M, Category = new List<string>{ "Laptop", "Computers" } },
        new Product { Id = Guid.NewGuid(), Name = "HP Spectre x360", Description = "Convertible laptop with touchscreen.", ImageFile = "p13.png", Price = 1399M, Category = new List<string>{ "Laptop" } },
        new Product { Id = Guid.NewGuid(), Name = "Lenovo ThinkPad X1", Description = "Business laptop with robust build.", ImageFile = "p14.png", Price = 1599M, Category = new List<string>{ "Laptop" } },
        new Product { Id = Guid.NewGuid(), Name = "Asus ZenBook 14", Description = "Slim and powerful ultrabook.", ImageFile = "p15.png", Price = 1099M, Category = new List<string>{ "Laptop" } },
        new Product { Id = Guid.NewGuid(), Name = "Acer Swift 3", Description = "Budget-friendly lightweight laptop.", ImageFile = "p16.png", Price = 799M, Category = new List<string>{ "Laptop" } },
        new Product { Id = Guid.NewGuid(), Name = "MSI Stealth 15", Description = "Gaming laptop with RTX graphics.", ImageFile = "p17.png", Price = 1799M, Category = new List<string>{ "Laptop", "Gaming" } },
        new Product { Id = Guid.NewGuid(), Name = "Razer Blade 16", Description = "Premium gaming laptop.", ImageFile = "p18.png", Price = 2499M, Category = new List<string>{ "Laptop", "Gaming" } },
        new Product { Id = Guid.NewGuid(), Name = "Samsung Galaxy Book3", Description = "Elegant and powerful laptop.", ImageFile = "p19.png", Price = 1299M, Category = new List<string>{ "Laptop" } },
        new Product { Id = Guid.NewGuid(), Name = "LG Gram 17", Description = "Ultra-light large screen laptop.", ImageFile = "p20.png", Price = 1699M, Category = new List<string>{ "Laptop" } },

        // COMPUTERS (10)
        new Product { Id = Guid.NewGuid(), Name = "iMac 24", Description = "All-in-one Apple desktop.", ImageFile = "p21.png", Price = 1799M, Category = new List<string>{ "Computers" } },
        new Product { Id = Guid.NewGuid(), Name = "Dell OptiPlex", Description = "Reliable office desktop.", ImageFile = "p22.png", Price = 899M, Category = new List<string>{ "Computers" } },
        new Product { Id = Guid.NewGuid(), Name = "HP Envy Desktop", Description = "High performance desktop.", ImageFile = "p23.png", Price = 1099M, Category = new List<string>{ "Computers" } },
        new Product { Id = Guid.NewGuid(), Name = "Lenovo IdeaCentre", Description = "Affordable desktop solution.", ImageFile = "p24.png", Price = 699M, Category = new List<string>{ "Computers" } },
        new Product { Id = Guid.NewGuid(), Name = "Custom Gaming PC", Description = "High-end gaming desktop.", ImageFile = "p25.png", Price = 1999M, Category = new List<string>{ "Computers", "Gaming" } },
        new Product { Id = Guid.NewGuid(), Name = "Mini PC Intel NUC", Description = "Compact and powerful mini PC.", ImageFile = "p26.png", Price = 599M, Category = new List<string>{ "Computers" } },
        new Product { Id = Guid.NewGuid(), Name = "Asus ROG Desktop", Description = "Gaming desktop powerhouse.", ImageFile = "p27.png", Price = 2199M, Category = new List<string>{ "Computers", "Gaming" } },
        new Product { Id = Guid.NewGuid(), Name = "Acer Aspire TC", Description = "Budget desktop computer.", ImageFile = "p28.png", Price = 499M, Category = new List<string>{ "Computers" } },
        new Product { Id = Guid.NewGuid(), Name = "CyberPowerPC Gamer Xtreme", Description = "Prebuilt gaming PC.", ImageFile = "p29.png", Price = 1499M, Category = new List<string>{ "Computers", "Gaming" } },
        new Product { Id = Guid.NewGuid(), Name = "Apple Mac Mini", Description = "Compact desktop with M2 chip.", ImageFile = "p30.png", Price = 699M, Category = new List<string>{ "Computers" } },

        // WEARABLES (10)
        new Product { Id = Guid.NewGuid(), Name = "Apple Watch Ultra", Description = "Rugged smartwatch for extreme sports.", ImageFile = "p31.png", Price = 799M, Category = new List<string>{ "Wearables" } },
        new Product { Id = Guid.NewGuid(), Name = "Samsung Galaxy Watch 6", Description = "Smartwatch with health tracking.", ImageFile = "p32.png", Price = 399M, Category = new List<string>{ "Wearables" } },
        new Product { Id = Guid.NewGuid(), Name = "Fitbit Versa 4", Description = "Fitness tracking smartwatch.", ImageFile = "p33.png", Price = 249M, Category = new List<string>{ "Wearables" } },
        new Product { Id = Guid.NewGuid(), Name = "Garmin Fenix 7", Description = "Advanced sports smartwatch.", ImageFile = "p34.png", Price = 699M, Category = new List<string>{ "Wearables" } },
        new Product { Id = Guid.NewGuid(), Name = "Huawei Watch GT 3", Description = "Elegant smartwatch.", ImageFile = "p35.png", Price = 299M, Category = new List<string>{ "Wearables" } },
        new Product { Id = Guid.NewGuid(), Name = "Amazfit GTR 4", Description = "Affordable smartwatch.", ImageFile = "p36.png", Price = 199M, Category = new List<string>{ "Wearables" } },
        new Product { Id = Guid.NewGuid(), Name = "Oura Ring", Description = "Smart ring for health tracking.", ImageFile = "p37.png", Price = 299M, Category = new List<string>{ "Wearables" } },
        new Product { Id = Guid.NewGuid(), Name = "Whoop Strap 4.0", Description = "Performance tracking wearable.", ImageFile = "p38.png", Price = 299M, Category = new List<string>{ "Wearables" } },
        new Product { Id = Guid.NewGuid(), Name = "Xiaomi Smart Band 8", Description = "Budget fitness band.", ImageFile = "p39.png", Price = 59M, Category = new List<string>{ "Wearables" } },
        new Product { Id = Guid.NewGuid(), Name = "Polar Ignite 3", Description = "Fitness-focused smartwatch.", ImageFile = "p40.png", Price = 329M, Category = new List<string>{ "Wearables" } },

        // SMART TVs (10)
        new Product { Id = Guid.NewGuid(), Name = "Samsung 65\" QLED", Description = "4K QLED Smart TV.", ImageFile = "p41.png", Price = 1499M, Category = new List<string>{ "Smart TV" } },
        new Product { Id = Guid.NewGuid(), Name = "LG OLED 55\"", Description = "OLED Smart TV.", ImageFile = "p42.png", Price = 1299M, Category = new List<string>{ "Smart TV" } },
        new Product { Id = Guid.NewGuid(), Name = "Sony Bravia XR", Description = "Premium 4K Smart TV.", ImageFile = "p43.png", Price = 1599M, Category = new List<string>{ "Smart TV" } },
        new Product { Id = Guid.NewGuid(), Name = "TCL 6-Series", Description = "Affordable QLED TV.", ImageFile = "p44.png", Price = 799M, Category = new List<string>{ "Smart TV" } },
        new Product { Id = Guid.NewGuid(), Name = "Hisense U8H", Description = "High brightness 4K TV.", ImageFile = "p45.png", Price = 899M, Category = new List<string>{ "Smart TV" } },
        new Product { Id = Guid.NewGuid(), Name = "Vizio P-Series", Description = "Dolby Vision Smart TV.", ImageFile = "p46.png", Price = 999M, Category = new List<string>{ "Smart TV" } },
        new Product { Id = Guid.NewGuid(), Name = "Philips Ambilight TV", Description = "Immersive lighting TV.", ImageFile = "p47.png", Price = 1199M, Category = new List<string>{ "Smart TV" } },
        new Product { Id = Guid.NewGuid(), Name = "Panasonic 4K TV", Description = "Reliable smart TV.", ImageFile = "p48.png", Price = 899M, Category = new List<string>{ "Smart TV" } },
        new Product { Id = Guid.NewGuid(), Name = "Sharp Aquos", Description = "Budget smart TV.", ImageFile = "p49.png", Price = 699M, Category = new List<string>{ "Smart TV" } },
        new Product { Id = Guid.NewGuid(), Name = "Insignia Fire TV", Description = "Amazon integrated TV.", ImageFile = "p50.png", Price = 499M, Category = new List<string>{ "Smart TV" } },

        // PRINTERS (10)
        new Product { Id = Guid.NewGuid(), Name = "HP OfficeJet Pro", Description = "All-in-one printer.", ImageFile = "p51.png", Price = 299M, Category = new List<string>{ "Printers" } },
        new Product { Id = Guid.NewGuid(), Name = "Canon PIXMA TS", Description = "Photo printer.", ImageFile = "p52.png", Price = 199M, Category = new List<string>{ "Printers" } },
        new Product { Id = Guid.NewGuid(), Name = "Epson EcoTank", Description = "Ink tank printer.", ImageFile = "p53.png", Price = 349M, Category = new List<string>{ "Printers" } },
        new Product { Id = Guid.NewGuid(), Name = "Brother HL-L2350DW", Description = "Laser printer.", ImageFile = "p54.png", Price = 149M, Category = new List<string>{ "Printers" } },
        new Product { Id = Guid.NewGuid(), Name = "Lexmark MB2236adw", Description = "Office printer.", ImageFile = "p55.png", Price = 229M, Category = new List<string>{ "Printers" } },
        new Product { Id = Guid.NewGuid(), Name = "Samsung Xpress", Description = "Compact laser printer.", ImageFile = "p56.png", Price = 199M, Category = new List<string>{ "Printers" } },
        new Product { Id = Guid.NewGuid(), Name = "Ricoh SP 230DNw", Description = "Business printer.", ImageFile = "p57.png", Price = 249M, Category = new List<string>{ "Printers" } },
        new Product { Id = Guid.NewGuid(), Name = "Xerox Phaser 6510", Description = "Color laser printer.", ImageFile = "p58.png", Price = 399M, Category = new List<string>{ "Printers" } },
        new Product { Id = Guid.NewGuid(), Name = "Kyocera Ecosys", Description = "Eco-friendly printer.", ImageFile = "p59.png", Price = 299M, Category = new List<string>{ "Printers" } },
        new Product { Id = Guid.NewGuid(), Name = "Dell Color Cloud Printer", Description = "Cloud-enabled printer.", ImageFile = "p60.png", Price = 279M, Category = new List<string>{ "Printers" } },

        // ACCESSORIES / AUDIO / NETWORKING / GAMING MIX (40)
        new Product { Id = Guid.NewGuid(), Name = "Logitech MX Keys", Description = "Wireless keyboard.", ImageFile = "p61.png", Price = 129M, Category = new List<string>{ "Accessories" } },
        new Product { Id = Guid.NewGuid(), Name = "Razer DeathAdder", Description = "Gaming mouse.", ImageFile = "p62.png", Price = 79M, Category = new List<string>{ "Gaming", "Accessories" } },
        new Product { Id = Guid.NewGuid(), Name = "Corsair Headset", Description = "Gaming headset.", ImageFile = "p63.png", Price = 99M, Category = new List<string>{ "Gaming", "Audio" } },
        new Product { Id = Guid.NewGuid(), Name = "Sony WH-1000XM5", Description = "Noise canceling headphones.", ImageFile = "p64.png", Price = 399M, Category = new List<string>{ "Audio" } },
        new Product { Id = Guid.NewGuid(), Name = "Bose SoundLink", Description = "Bluetooth speaker.", ImageFile = "p65.png", Price = 199M, Category = new List<string>{ "Audio" } },
        new Product { Id = Guid.NewGuid(), Name = "JBL Charge 5", Description = "Portable speaker.", ImageFile = "p66.png", Price = 179M, Category = new List<string>{ "Audio" } },
        new Product { Id = Guid.NewGuid(), Name = "TP-Link Router AX50", Description = "WiFi 6 router.", ImageFile = "p67.png", Price = 149M, Category = new List<string>{ "Networking" } },
        new Product { Id = Guid.NewGuid(), Name = "Netgear Nighthawk", Description = "Gaming router.", ImageFile = "p68.png", Price = 299M, Category = new List<string>{ "Networking", "Gaming" } },
        new Product { Id = Guid.NewGuid(), Name = "PlayStation 5", Description = "Next-gen console.", ImageFile = "p69.png", Price = 499M, Category = new List<string>{ "Gaming" } },
        new Product { Id = Guid.NewGuid(), Name = "Xbox Series X", Description = "Powerful console.", ImageFile = "p70.png", Price = 499M, Category = new List<string>{ "Gaming" } },

        // continue up to 100...
        new Product { Id = Guid.NewGuid(), Name = "Nintendo Switch OLED", Description = "Hybrid gaming console.", ImageFile = "p71.png", Price = 349M, Category = new List<string>{ "Gaming" } },
        new Product { Id = Guid.NewGuid(), Name = "Elgato Stream Deck", Description = "Streaming controller.", ImageFile = "p72.png", Price = 149M, Category = new List<string>{ "Accessories" } },
        new Product { Id = Guid.NewGuid(), Name = "WD 2TB External HDD", Description = "Portable storage.", ImageFile = "p73.png", Price = 89M, Category = new List<string>{ "Accessories" } },
        new Product { Id = Guid.NewGuid(), Name = "Samsung T7 SSD", Description = "Fast external SSD.", ImageFile = "p74.png", Price = 129M, Category = new List<string>{ "Accessories" } },
        new Product { Id = Guid.NewGuid(), Name = "Anker Power Bank", Description = "Portable charger.", ImageFile = "p75.png", Price = 49M, Category = new List<string>{ "Accessories" } },
        new Product { Id = Guid.NewGuid(), Name = "Belkin Wireless Charger", Description = "Qi charger.", ImageFile = "p76.png", Price = 39M, Category = new List<string>{ "Accessories" } },
        new Product { Id = Guid.NewGuid(), Name = "Logitech Webcam C920", Description = "HD webcam.", ImageFile = "p77.png", Price = 89M, Category = new List<string>{ "Accessories" } },
        new Product { Id = Guid.NewGuid(), Name = "Ring Video Doorbell", Description = "Smart security.", ImageFile = "p78.png", Price = 199M, Category = new List<string>{ "Networking" } },
        new Product { Id = Guid.NewGuid(), Name = "Google Nest Hub", Description = "Smart display.", ImageFile = "p79.png", Price = 129M, Category = new List<string>{ "Smart Home" } },
        new Product { Id = Guid.NewGuid(), Name = "Amazon Echo Dot", Description = "Smart speaker.", ImageFile = "p80.png", Price = 49M, Category = new List<string>{ "Smart Home" } },

        // FINAL 20
        new Product { Id = Guid.NewGuid(), Name = "Philips Hue Bulb", Description = "Smart lighting.", ImageFile = "p81.png", Price = 59M, Category = new List<string>{ "Smart Home" } },
        new Product { Id = Guid.NewGuid(), Name = "Arlo Security Camera", Description = "Wireless camera.", ImageFile = "p82.png", Price = 249M, Category = new List<string>{ "Smart Home" } },
        new Product { Id = Guid.NewGuid(), Name = "Dyson Air Purifier", Description = "Air purifier.", ImageFile = "p83.png", Price = 499M, Category = new List<string>{ "Smart Home" } },
        new Product { Id = Guid.NewGuid(), Name = "iRobot Roomba", Description = "Robot vacuum.", ImageFile = "p84.png", Price = 399M, Category = new List<string>{ "Smart Home" } },
        new Product { Id = Guid.NewGuid(), Name = "GoPro Hero 12", Description = "Action camera.", ImageFile = "p85.png", Price = 399M, Category = new List<string>{ "Cameras" } },
        new Product { Id = Guid.NewGuid(), Name = "Canon EOS R6", Description = "Mirrorless camera.", ImageFile = "p86.png", Price = 2499M, Category = new List<string>{ "Cameras" } },
        new Product { Id = Guid.NewGuid(), Name = "Nikon Z6 II", Description = "Professional camera.", ImageFile = "p87.png", Price = 1999M, Category = new List<string>{ "Cameras" } },
        new Product { Id = Guid.NewGuid(), Name = "DJI Mini 3", Description = "Compact drone.", ImageFile = "p88.png", Price = 799M, Category = new List<string>{ "Drones" } },
        new Product { Id = Guid.NewGuid(), Name = "DJI Air 3", Description = "Advanced drone.", ImageFile = "p89.png", Price = 1199M, Category = new List<string>{ "Drones" } },
        new Product { Id = Guid.NewGuid(), Name = "Sandisk 128GB SD Card", Description = "Storage card.", ImageFile = "p90.png", Price = 29M, Category = new List<string>{ "Accessories" } },

        new Product { Id = Guid.NewGuid(), Name = "Seagate 4TB HDD", Description = "Internal storage.", ImageFile = "p91.png", Price = 109M, Category = new List<string>{ "Accessories" } },
        new Product { Id = Guid.NewGuid(), Name = "Intel Core i9 CPU", Description = "High-end processor.", ImageFile = "p92.png", Price = 599M, Category = new List<string>{ "Computers" } },
        new Product { Id = Guid.NewGuid(), Name = "AMD Ryzen 9", Description = "Powerful CPU.", ImageFile = "p93.png", Price = 549M, Category = new List<string>{ "Computers" } },
        new Product { Id = Guid.NewGuid(), Name = "NVIDIA RTX 4080", Description = "Graphics card.", ImageFile = "p94.png", Price = 1199M, Category = new List<string>{ "Computers", "Gaming" } },
        new Product { Id = Guid.NewGuid(), Name = "Corsair 32GB RAM", Description = "DDR5 memory.", ImageFile = "p95.png", Price = 199M, Category = new List<string>{ "Computers" } },
        new Product { Id = Guid.NewGuid(), Name = "ASUS Motherboard", Description = "Gaming motherboard.", ImageFile = "p96.png", Price = 299M, Category = new List<string>{ "Computers" } },
        new Product { Id = Guid.NewGuid(), Name = "Cooler Master PSU", Description = "Power supply unit.", ImageFile = "p97.png", Price = 149M, Category = new List<string>{ "Computers" } },
        new Product { Id = Guid.NewGuid(), Name = "NZXT PC Case", Description = "Mid tower case.", ImageFile = "p98.png", Price = 129M, Category = new List<string>{ "Computers" } },
        new Product { Id = Guid.NewGuid(), Name = "SteelSeries Mousepad", Description = "Gaming mousepad.", ImageFile = "p99.png", Price = 29M, Category = new List<string>{ "Gaming" } },
        new Product { Id = Guid.NewGuid(), Name = "HyperX USB Mic", Description = "Streaming microphone.", ImageFile = "p100.png", Price = 149M, Category = new List<string>{ "Audio" } },
    };
}
