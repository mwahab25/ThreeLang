package Java;

class Pages {
    //private int id;
    //private String name;
    public static void main(final String[] args) {
        Pages page=new HomePage();
        page.Print();

    }

    public Pages()
    {
        System.out.println("Pages Constructor");
    }

    void Init(){

    }

    void Print(){
        System.out.println("Pages Print");
    }

    protected void AcceptCookie(){

    }

    
    public void HeadMenu(){

    }

    public int HeadNum(){
        return 0;

    }
}


class HomePage extends Pages {
    //private int num;
    HomePage(){
        System.out.println("HomePage Constructor");
    }

   
    void PrintS(){
        System.out.println("HomePage Print");

    }

    void PrintHomePage(){

    }

    void PrintHomePage(String n){

    }
}