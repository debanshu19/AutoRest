/**
 */

package petstore.models;


/**
 * The Category model.
 */
public class Category {
    /**
     * The id property.
     */
    private Long id;

    /**
     * The name property.
     */
    private String name;

    /**
     * Get the id value.
     *
     * @return the id value
     */
    public Long getId() {
        return this.id;
    }

    /**
     * Set the id value.
     *
     * @param id the id value to set
     */
    public void setId(Long id) {
        this.id = id;
    }

    /**
     * Get the name value.
     *
     * @return the name value
     */
    public String getName() {
        return this.name;
    }

    /**
     * Set the name value.
     *
     * @param name the name value to set
     */
    public void setName(String name) {
        this.name = name;
    }

}
