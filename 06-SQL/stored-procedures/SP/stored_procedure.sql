
EXEC [getUserOrderDetailsByUserName] 'Tom';
Create PROCEDURE dbo.getUserOrderDetailsByUserName
    @userName varchar(20)
AS
BEGIN
    DROP TABLE IF EXISTS #userWithOrders;

    SELECT
    [user].userId,
    [user].customerName,
    [user].phoneNumber,
    [order].orderId
    into #userWithOrders
    From users [user]
    Join orders [order] on [order].[orderBy] = [user].[userId]
    where [user].customerName LIKE '%' +@userName+ '%';


    SELECT
    [uwo].*,
    COUNT(orderProduct.id) as noOfProductsOrdered,
    SUM(product.price) as totalOrderPrice,
    Max(product.price) as highestProductPrice
    From #userWithOrders uwo
    Join orderProducts orderProduct on orderProduct.orderId = [uwo].[orderId]
    Join products product on product.productId = [orderProduct].productId

    Group By 
    [uwo].[userId],
    [uwo].[customerName],
    [uwo].[phoneNumber],
    [uwo].[orderId];
END
GO






