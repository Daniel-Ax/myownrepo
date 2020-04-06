import pygame

class kocka:
    def __init__(self, display):
        self.coord = (670, 250)
        self.display = display
        self.dobasEgy = pygame.image.load("dice_one.png")
        self.dobasKetto = pygame.image.load("dice_two.png")
        self.dobasHarom = pygame.image.load("dice_three.png")
        self.dobasNegy = pygame.image.load("dice_four.png")
        self.dobasOt = pygame.image.load("dice_five.png")
        self.dobasHat = pygame.image.load("dice_six.png")

    def egyes(self):
        self.display.blit(self.dobasEgy, self.coord)

    def kettes(self):
        self.display.blit(self.dobasKetto, self.coord)

    def harmas(self):
        self.display.blit(self.dobasHarom, self.coord)

    def negyes(self):
        self.display.blit(self.dobasNegy, self.coord)

    def otos(self):
        self.display.blit(self.dobasOt, self.coord)

    def hatos(self):
        self.display.blit(self.dobasHat, self.coord)
