## _[ PIERRE'S BOULANGERIE ]_  

### _A C# Terminal Application to buy some bread (and others)_

### _November 20th, 2020_  
----------------------
### Description:

This product is a C# Terminal application where you play the part of a customer at Pierre's Parisian Boulangerie. Through a series of text inputs, the user is able to select a number of pastries and/or loaves of bread to purchase, and to receive discounts based on the quantity selected.

### Project Criteria:  

As referenced from the [Epicodus](https://epicodus.com) program's curriculum:  

Create a C# console application for a bakery that includes the following functionality:

> There should be two classes: one for `Bread` and one for `Pastry`.
>
> When the user runs the application, they should receive a prompt with a welcome message along with the cost for both `Bread` and `Pastry`.
>
> A user should be able to specify how many loaves of [`Bread`] and how many [`Pastry`]s they'd like.
>
> The application will return the total cost of the order.
>
> Pierre offers the following deals:
>    `Bread`: Buy 2, get 1 free. A single loaf costs $5.
>    `Pastry`: Buy 1 for $2, or 3 for $5.
>
> All functionality for the models should be tested.

-------------------------------

#### Project Specs:  
#### Console:
- Console is to greet the user, offer them a menu of products and deals, and then allow them to make purchases.
- Console is able to tell which product user has selected, and will be able to calculate discount based on specific product.
- Console will allow user to go back and change quantity of products selected, or start over, if they make an error.
- Console will handle general anticipated errors, such as:
> - Attempting to make payment with an empty cart.
> - Attempting to purchase negative quantities of product.
> - Failing to select menu items, or use non-integers for purchase quantities.

##### Pricing:
Both specified discounts operate on a "buy two (at full price), get one (at X price)" model.\
\
Bread Pricing (Buy two, get one free, each loaf at $5):\
 _$5, $5, $0, $5, $5, $0, $5, $5, [...]_\
Pastry Pricing (Three for $5, or One for $2):\
_$2, $2, $1, $2, $2, $1, $2, $2, [...]_\
\
As such, discount tabulation runs as follows:

- _`Quantity`_ = the total number of items in the cart.

- _`Quantity % 3`_ = the number of items that fall outside the "buy two, get one" calculation. This value (0, 1, or 2) is calculated at full price. We'll call this `ExcessQuantity`

- _`Quantity - ExcessQuantity`_ = the total number of items that _do_ fall within the bounds of "buy two, get one" calculations. We'll call this `WithinDealQuantity`.

- _`WithinDealQuantity / 3`_ = One-third of all items within the "buy two, get one" deal. These are the "get one (at price X)" items. This will be our `AtDiscountQuantity`. 

- _`Quantity - AtDiscountQuantity`_ = the total number of items that cost the full price. This is _both_ the "buy two" items of the deal, as well as all items that fall outside the bounds of the deal. We'll call this `FullPriceQuantity`.

With all this in mind, the final cart tabulation for both types of items is as follows:\
\
 **(** _`FullPriceQuantity * [Full Price of Item]`_ **)**\
+ 
**(** _`AtDiscountQuantity * [Discount Price of Item]`_ **)**\
= [ _`Final Cart Total`_ ].

Or, if one buys ten (10) items:
- Quantity = 10
- Excess Quantity = 10 % 3 = 1
- Within Deal Quantity = 10 - 1 = 9
- At Discount Quantity = 9 / 3 = 3
- Full Price Quantity = 10 - 3 = 7

If one is buying Bread: 
- Final Cart Total = (7 * $5) + (3 * $0) = $35\
vs
- ($5 + $5 + $0) + ($5 + $5 + $0) + ($5 + $5 + $0) + $5 = $35

If one is buying Pastries:
- Final Cart Total = (7 * $2) + (3 * $1) = $17\
vs
- ($2 + $2 + $1) + ($2 + $2 + $1) + ($2 + $2 + $1) + $2 = $17
------------------------------

#### Known Issues / Bugs:    
None currently known.

-------------------------------

#### Setup:

 Prior to downloading:
> **Note:** You will need to have [.NET](https://dotnet.microsoft.com/download/dotnet-core/2.2) installed on your machine prior to downloading this project.\
 This project was coded using `.NET Version: 2.2.203`.\
 While you do not have to have this specific version installed locally, compatibility cannot be guaranteed with earlier or later releases of the .NET core. 

##### To view locally on your machine:  
1. Find the green **Code** button above the file list on this project's [main GitHub repository page](https://github.com/grand-scheme/Boulangerie.Solution).
2. Select the button to open a drop-down menu. Select "Open with GitHub Desktop" or, if you do not have this program installed, download the compressed .zip file.
3. Extract the .zip file to your local machine.
4. Directions were accurate as of December 11th, 2020. If GitHub has since changed their protocol, please see [the GitHub help docs](https://docs.github.com/en) for up-to-date information.

##### To clone this project to your machine:  
> The following directions are based on Git Bash for a Windows machine; you may have to adjust terminology based on your local specs.
1. Launch your terminal of choice. 

2. Navigate to the containing directory into which you would like to clone this project.

3. Input:\
`$ git clone https://github.com/grand-scheme/Boulangerie.Solution`

4. This will clone the project to a folder called "Boulangerie.Solution." If you wish to clone it into a directory of a different name, append the new folder name to the end of the string, like so:\
`$ git clone https://github.com/grand-scheme/Boulangerie.Solution NEW-FOLDER`\
where `NEW-FOLDER` is where you would type the name of the folder you would like to use.\
**Note:** It is highly recommended that your destination folder retains the name `Boulangerie.Solution`.  

5. Directions were accurate as of Dec. 11th, 2020. If GitHub has since changed their protocol, please see [the GitHub help docs](https://docs.github.com/en) for up-to-date information.

#### To run this project on your machine:
1. Once you have the project locally stored, navigate to its main directory in your terminal of choice. By default, this is `Boulangerie.Solution`. 

2. Navigate to the subfolder `Boulangerie`.

3. In your command line, input\
`$ dotnet build`\
`$ dotnet run`

4. If all goes well, Pierre should greet you in the command console itself. 

##### To engage with the test suite:
> Note: it is recommended to run the project and the previously-enumerated dotnet commands before engaging with the test suite.
1. Navigate to the main directory in your terminal of choice. By default, this is `Boulangerie.Solution`.

2. Navigate to the subfolder `Boulangerie.Tests`.

3. In your command line, input\
`$ dotnet test`

4. After a moment, the tests should execute.
-------------------------------

#### Technologies Used:  
- Coded in Visual Studio Code.
- .NET Core SDK Version: 2.2.203

##### License
- _GNU AGPLv3_  
- Project copyright (c) 2020 **_Shannon Grantski_**  
- Project criteria quoted text copyright (c) 2020 Epicodus, Inc.