class Pages:
    def __init__(self,id,name):
        self.id=id
        self.name=name

    def init(self):
        print("id is {} and name is {}".format(self.id,self.name))



page=Pages(200,"mic")
you=Pages(300,"yum")

print(page.id)
print(you.name)
you.init()

#inheritance
class HomePage(Pages):
    def __init__(self,num,id,name):
        super().__init__(id,name)
        self.num=num

    def hurt(self,ot):
        if self.num=='rock':
            ot.name='sasa'
        elif self.num=='stick':
            ot.name='rara'
        print(ot.name)

home=HomePage('rock','daa','raaa')
home.hurt(page)
