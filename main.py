import pygame
import random
from fuggvenyek import egy_babura_kattintott
import kockak
from babu import Babu

# Kepernyő inicializálása
pygame.init()
width = 800
height = 600
gameDisplay = pygame.display.set_mode((width, height))
pygame.display.set_caption('Ki nevet a végén')
# előre definiált színek
black = (0, 0, 0)
white = (255, 255, 255)
green = (0, 255, 0)
red = (255, 0, 0)
blue = (0, 0, 255)
yellow = (255, 255, 0)
clock = pygame.time.Clock()
board = pygame.image.load('kep.png')

# egy csoport tárolom a bábukat így könnyebb lesz kirajzolni öket
babuk_csapat = pygame.sprite.Group()

# ezzel a függvénnyel jelenítem meg a játék teret
def tabla(x,y):

    gameDisplay.blit(board, (x,y))

kocka = kockak.kocka(gameDisplay)

def korok_sorrend():
    sorszam = [0, 1, 2, 3]
    for event in pygame.event.get():
        if event.type == pygame.MOUSEBUTTONDOWN:
            a, b = pygame.mouse.get_pos()
            # elég csak ezt meg hívni és ugyanazt meg fogja tenni mert nem kell még egy loopot
            # futtatni a game loopon belül
            if 40 + 565 < a and b > 40 + 565:
                for i in sorszam:

                    if sorszam[0] == 0:
                        gameDisplay.fill(red)
                    elif sorszam[1] == 1:
                        gameDisplay.fill(green)
                    elif sorszam[2] == 2:
                        gameDisplay.fill(blue)
                    elif sorszam[3] == 3:

                        gameDisplay.fill(yellow)



def babukirajzol(a,b,szin, szin_index):
    coord = ((0,0),(2,0),(2,2),(0,2))
    lista = []
    
    for i in coord:
        x=a+i[0]
        y=b+i[1]
        lista.append(Babu(gameDisplay,(x, y), szin, szin_index))
        
    return lista
        

def display_first(first):
    
    # egyes dobo kocka
    if (first == 1):
        kocka.egyes()
        #gameDisplay.blit(dobasEgy, (670, 250))
    # kettes dobo kocka
    elif (first == 2):
        kocka.kettes()
    # harmas dobo kocka
    elif (first == 3):
        kocka.harmas()
    # negyes dobo kocka
    elif (first == 4):
        kocka.negyes()
    # ötös dobo kocka
    elif (first == 5):
        kocka.otos()
    # hatos dobo kocka
    elif (first == 6):
        kocka.hatos()


def main():
    
    coordLista=[(0, 6),(1, 6),(2, 6),(3, 6),(4, 6),(5, 6),(6, 6),
    (6, 5),(6, 4),(6, 3),(6, 2),(6, 1),(6, 0),(7, 0),
    (8, 0),(8, 1),(8, 2),(8, 3),(8, 4),(8, 5),(8, 6),(9, 6),(10, 6),
    (11, 6),(12, 6),(13, 6),(14, 6),(14, 7),(14, 8),(13, 8),(12, 8),
    (11, 8),(10, 8),(9, 8),(8, 8),(8, 9),(8, 10),(8, 11),(8, 12),(8, 13),
    (8, 14),(7, 14),(6, 14),(6, 13),(6, 12),(6, 11),(6, 10),(6, 9),(6, 8),
    (5, 8),(4, 8),(3, 8),(2, 8),(1, 8),(0, 8),(0, 7)]

    pirosGyoz=[(1,7),(2,7),(3,7),(4,7),(5,7)]
    zoldGyoz=[(7,1),(7,2),(7,3),(7,4),(7,5)]
    sargaGyoz=[(7,9),(7,10),(7,11),(7,12),(7,13)]
    kekGyoz=[(13,7),(12,7),(11,7),(10,7),(9,7)]
    Gyozlista = [pirosGyoz,zoldGyoz,sargaGyoz, kekGyoz]
    x = 40
    y = 30
    quit = False

    kocka_ertek = None
    gameDisplay.fill(green)
    
    szin_index = 0
    szin_lista = [green, red, yellow, blue]

    #babu = pygame.draw.rect(gameDisplay, red, [40 + 33 * 8, 30, 36, 38])
    #56 vege
    babuLista=[babukirajzol(11,1,green,14),babukirajzol(1,1,red,0),babukirajzol(1,11,yellow,42),
                babukirajzol(11,11,blue,28)]
    while not quit:
        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                quit = True

            if event.type == pygame.MOUSEBUTTONDOWN:
                a, b = pygame.mouse.get_pos()

                if 40 + 565 > a and b < 40 + 565:
                    # babu mozgatás ha a otáblán belüre kattinta felhasználó

                    a = int(a/38)
                    b = int(b/38)
                    ma = 38
                    mb = 38
                    #tabla(x, y)
                    # itt korigálom hogy a kockán belül maradjanak a kockák
                    if a > 4:
                        ma -= 0.3
                    if b > 5:
                        mb -= 0.3
                    
                    
##                  ez a függvény ellenőrzi hogy babura kattintott-e a felhasználó
                    babu_ertek = egy_babura_kattintott(a,b, babuLista,szin_index)
                      
                    
                    
                    if babu_ertek != None:
                        i = babu_ertek.szin_index + babu_ertek.lepes_szam + kocka_ertek
                        if i > 54:
                            i -= 54
                        babu_ertek.mozgat(coordLista[i][0], coordLista[i][1])
                        babu_ertek.lepes_szam += kocka_ertek
                        if babu_ertek.lepes_szam >= 53:
                            babu_ertek.mozgat(Gyozlista[szin_index][0][0], Gyozlista[szin_index][1][1])
                            talalt = 0
                            for j in babuLista[szin_index]:
                                print(j.pozicio,Gyozlista[szin_index][0])
                                if j.pozicio == Gyozlista[szin_index][0]:
                                    talalt += 1
                            print(talalt)
                            if talalt == 4:
                                print("nyert")
                        

                    #print(babu)
                    print(a, b)

                else:
                    # ezt meg lehetne oldani choice al is nem kell számokat használni 
                    kocka_ertek = random.randint(1, 6)
                    szin_index += 1
                    if szin_index > 3:
                        szin_index = 0
                    gameDisplay.fill(szin_lista[szin_index])
                    display_first(kocka_ertek)

        tabla(x,y)
        for i in babuLista:
            for j in i:
                pygame.display.update(j.kirajzol())
                
        pygame.display.update()
        clock.tick(60)
        # mindig meg kell addni a új poziciót

    pygame.quit()


# 36x36 egy kis kocka

# 565 × 565 a palya

main()
