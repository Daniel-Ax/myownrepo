import pygame
class Babu:
    """maga az osztály nagyon jó öttlet csak itt sokkal több mindent meg lehet
    csinálni ami egyszerübbé teszi a programot pl: egyes poziciók, kirajzolás, csoport kezelés, szinének a tárólása stb"""
    def __init__(self, display, pozicio, szin, szin_index):

        
        self.szin = szin
        self.display = display
        self.meret = 38
        self.pozicio = pozicio
        self.mozgat(pozicio[0],pozicio[1])
        self.szin_index = szin_index
        self.lepes_szam = 0
        
        
    # ami kirjzolja a egyes bábukat
    def kirajzol(self,x=None,y=None):
        if x == None and y == None:
            self.babuosszes=pygame.draw.rect(self.display, self.szin, [self.x, self.y, self.meret, self.meret])
        else:
            self.mozgat(x,y)
            self.babuosszes=pygame.draw.rect(self.display, self.szin, [self.x, self.y, self.meret, self.meret])
       
    def mozgat(self, x, y):
##        self.babuosszes = self.babuosszes.move(x,y)
        # ez a függvény létre hozza a babunak a koordinátáját
        mx = self.meret
        my = self.meret
        if x > 4:
            mx -= 0.3
        if y > 5:
            my -= 0.3
        self.x = 40 + mx * x
        self.y = 30 + my * y
