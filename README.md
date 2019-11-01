# Microservice101
trying to learn how microservice API gateway works


customer API : localhost:7001
```
localhost:7001/api/customer/getcustomers
localhost:7001/api/customer/getcustomer?customerId=1
```

product API - localhost:7002 

```
localhost:7002/api/product/getproducts
localhost:7002/api/product/getproduct?productId=101
```

Order API - localhost:7003

```
localhost:7003/api/order/getorders
localhost:7002/api/order/getorders?orderId=301
localhost:7002/api/order/CustomerOrder?customerId=1
```

We can access all API using - localhost:7000

```
localhost:7000/customer-api/
localhost:7000/product-api/
localhost:7000/order-api/
localhost:7000/customerAndOrder/{{customerId}}
```



