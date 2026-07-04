public class Main {

    public static void main(String[] args) {

        Logger logger1 = Logger.getInstance();
        logger1.log("Application Started");

        Logger logger2 = Logger.getInstance();
        logger2.log("Application Running");

        if (logger1 == logger2) {
            System.out.println("Only one Logger instance exists.");
        } else {
            System.out.println("More than one Logger instance exists.");
        }
    }
}