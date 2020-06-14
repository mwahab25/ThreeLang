package Java;

import java.util.*;

public class Program {
    public static void main(final String[] args) {

        //input,read data
        Scanner scan = new Scanner(System.in);
        String input = scan.next();

        //output, print data
        System.out.println("Hello " + input);
        scan.close();

        int id =6;
        String title = "Check login";
        char symbol=title.charAt(0);
        double peektime=45.54;
        boolean defaultflag=true;
        final double PI=3.14;

        System.out.println(String.format("id=%d,title=%s,symbol=%c,peektime=%s,defaultflag=%s,PI=%s", id,title,symbol,peektime,defaultflag,PI));

        //Decision - if 
        if(peektime > 10)
        {
            //write code
        }
        
         //Decision - if else
        if(peektime <10)
        {
            //write code
        }
        else
        {
            //write code
        }

        //Decision - if else if
        if(peektime > 10)
        {
            //write code
        }
        else if(peektime == 10)
        {
            //write code
        }
        else
        {
            //write code
        }

        //Decision - nested if
        if(peektime < 10)
        {
            if(peektime < 5)
            {
                //write code
            }
        }

        //Arrays
        int[] arr1=new int[3];
        arr1[0] = 4;
        arr1[1] = 5;
        arr1[2] = 3;

        int[] arr={1,3,5,6,7,8,9};

        //collections
        Set<Integer> se=new HashSet<Integer>();
        se.add(1);
        se.add(2);


        List<String> list=new ArrayList<String>();
        list.add("Chrome");
        list.add("Edge");
        list.add("Safari");
        
        //get list item
        //String g=list.get(0);

        Queue<String> que=new LinkedList<String>();
        que.add("Chrome");
        que.add("Edge");
        que.add("Safari");

        que.poll();

        Map<Integer,String> ma=new HashMap<Integer,String>();
        ma.put(1, "Chrome");
        ma.put(2, "Edge");

        System.out.println(ma.get(1));
        
        //Loops
        for (int i = 0; i < arr.length; i++) {
            System.out.println(arr[i]);
        }

        for (String brow : list) {
            System.out.println(brow);
        }

        int j=7;
        while(j > 3)
        {
           System.out.println(j);
            j--;
        }

        j=10;
        do{
            System.out.println(j);
            j--;
        }while(j<3);
        
        
        //Classes and objects
        Pages p =new Pages();
        p.Print();
    }
}