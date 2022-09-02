using ConsoleApp1;
Tootaja tootaja = new Tootaja("THK", "õpetaja", "Marina", 1989, Isik.Sugu.tudruk, 200, 600, 1400);
Opilane Opilane = new Opilane("THK", "opilane", "Aleksandr", 2005, Isik.Sugu.poiss, 100, 300, 700);
Kutsekooliopilane Kutsekooliopilane = new Kutsekooliopilane("THK", "kutsekooliopilane", "Dany", 2006, Isik.Sugu.poiss, 100, 300, 700);
tootaja.print_Info();
Opilane.print_Info();
Kutsekooliopilane.print_Info();