/**
 * Shipping Type Enum
 *
 * @author Ray Hunter ray.hunter@stgconsulting.com
 */
public enum ShippingTypeEnum {

    /* Shipping Types with associated costs */
    UPS('ups', 1.65),
    FEDEX('fedex', 2.15),
    USPS('usps', 3.75),
    DHL('dhl', 4.25)

    final String name
    final double value
    static final Map map

    static {
        map = [:] as TreeMap
        values().each { shippingTypeEnum ->
            map.put(shippingTypeEnum.name, shippingTypeEnum)
        }

    }

    private ShippingTypeEnum(String name, double value) {
        this.name = name;
        this.value = value;
    }

    static ShippingTypeEnum getShippingTypeEnum(String name) {
        map.get(name.toLowerCase())
    }

}
