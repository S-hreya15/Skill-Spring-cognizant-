import java.util.Arrays;

class Product implements Comparable<Product> {
    int productId;
    String productName;
    String category;

    Product(int productId, String productName, String category) {
        this.productId = productId;
        this.productName = productName;
        this.category = category;
    }

    @Override
    public int compareTo(Product p) {
        return this.productId - p.productId;
    }

    @Override
    public String toString() {
        return "ID: " + productId +
               ", Name: " + productName +
               ", Category: " + category;
    }
}

public class EcommercePlatform {

    // Linear Search
    static Product linearSearch(Product[] products, int id) {
        for (Product p : products) {
            if (p.productId == id)
                return p;
        }
        return null;
    }

    // Binary Search
    static Product binarySearch(Product[] products, int id) {
        int low = 0, high = products.length - 1;

        while (low <= high) {
            int mid = (low + high) / 2;

            if (products[mid].productId == id)
                return products[mid];
            else if (products[mid].productId < id)
                low = mid + 1;
            else
                high = mid - 1;
        }

        return null;
    }

    public static void main(String[] args) {

        Product[] products = {
            new Product(105, "Laptop", "Electronics"),
            new Product(101, "Phone", "Electronics"),
            new Product(103, "Shoes", "Fashion"),
            new Product(102, "Watch", "Accessories"),
            new Product(104, "Book", "Education")
        };

        int searchId = 103;

        System.out.println("Linear Search:");
        Product result = linearSearch(products, searchId);
        System.out.println(result != null ? result : "Product Not Found");

        Arrays.sort(products);

        System.out.println("\nBinary Search:");
        result = binarySearch(products, searchId);
        System.out.println(result != null ? result : "Product Not Found");

        System.out.println("\nTime Complexity Analysis");
        System.out.println("Linear Search: Best O(1), Average O(n), Worst O(n)");
        System.out.println("Binary Search: Best O(1), Average O(log n), Worst O(log n)");
        System.out.println("Binary Search is faster for large sorted datasets.");
    }
}