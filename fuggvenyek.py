def egy_babura_kattintott(x, y, lista,szin_index):
    i = lista[szin_index]
##  csak akkor léphetnek a babuk ha dobtak kockát
    
    for j in i:
##          az if megvizsgálja hogy a kockába kattintott e a felhasználó  
        if int((j.x)/38) <= x <= int((j.x+40)/38) and int((j.y)/38) <= y <= int((j.y+30)/38):
            
            return j
    return None
    
