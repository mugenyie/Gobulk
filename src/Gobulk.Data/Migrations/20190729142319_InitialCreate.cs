using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gobulk.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    CurrencyCode = table.Column<string>(nullable: false),
                    SymbolThumbnailUri = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedBy = table.Column<string>(nullable: true),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    LongDescription = table.Column<string>(nullable: true),
                    ShortDescription = table.Column<string>(nullable: true),
                    ActivatedOn = table.Column<DateTime>(nullable: true),
                    DeactivatedOn = table.Column<DateTime>(nullable: true),
                    ActivatedBy = table.Column<string>(nullable: true),
                    DeactivatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.CurrencyCode);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryCode = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ShortDescription = table.Column<string>(nullable: true),
                    LongDescription = table.Column<string>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    FlagThumbnailUri = table.Column<string>(nullable: true),
                    ActivatedOn = table.Column<DateTime>(nullable: true),
                    DeactivatedOn = table.Column<DateTime>(nullable: true),
                    ActivatedBy = table.Column<string>(nullable: true),
                    DeactivatedBy = table.Column<string>(nullable: true),
                    CurrencyCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryCode);
                    table.ForeignKey(
                        name: "FK_Countries_Currencies_CurrencyCode",
                        column: x => x.CurrencyCode,
                        principalTable: "Currencies",
                        principalColumn: "CurrencyCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    SettingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    MinimumTransactionAmount = table.Column<decimal>(nullable: false),
                    MaximumTransactionAmount = table.Column<decimal>(nullable: false),
                    TransactionPlan = table.Column<int>(nullable: false),
                    TransactionPlanTotalAmount = table.Column<decimal>(nullable: false),
                    MinimumBalance = table.Column<decimal>(nullable: false),
                    AccountType = table.Column<int>(nullable: false),
                    CurrencyCode = table.Column<string>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedBy = table.Column<string>(nullable: true),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    ShortDescription = table.Column<string>(nullable: true),
                    LongDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.SettingId);
                    table.ForeignKey(
                        name: "FK_Settings_Currencies_CurrencyCode",
                        column: x => x.CurrencyCode,
                        principalTable: "Currencies",
                        principalColumn: "CurrencyCode",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<string>(nullable: false),
                    RequestJsonSchema = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    FlatCommission = table.Column<decimal>(nullable: false),
                    PercentageCommission = table.Column<decimal>(nullable: false),
                    ProductUri = table.Column<string>(maxLength: 512, nullable: false),
                    ProductApiKey = table.Column<string>(maxLength: 512, nullable: true),
                    ShortDescription = table.Column<string>(nullable: true),
                    LongDescription = table.Column<string>(nullable: false),
                    CurrencyCode = table.Column<string>(nullable: false),
                    CountryCode = table.Column<string>(nullable: false),
                    ImageUri = table.Column<string>(nullable: true),
                    ThumbnailUri = table.Column<string>(nullable: true),
                    ItemsUri = table.Column<string>(maxLength: 512, nullable: true),
                    Website = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsPublic = table.Column<bool>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Category = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedBy = table.Column<string>(nullable: true),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    ActivatedOn = table.Column<DateTime>(nullable: true),
                    DeactivatedOn = table.Column<DateTime>(nullable: true),
                    ActivatedBy = table.Column<string>(nullable: true),
                    DeactivatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Countries_CountryCode",
                        column: x => x.CountryCode,
                        principalTable: "Countries",
                        principalColumn: "CountryCode",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Products_Currencies_CurrencyCode",
                        column: x => x.CurrencyCode,
                        principalTable: "Currencies",
                        principalColumn: "CurrencyCode",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Providers",
                columns: table => new
                {
                    ProviderId = table.Column<string>(nullable: false),
                    RequestJsonSchema = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    FlatFee = table.Column<decimal>(nullable: false),
                    PercentageFee = table.Column<decimal>(nullable: false),
                    ShortDescription = table.Column<string>(nullable: true),
                    LongDescription = table.Column<string>(nullable: false),
                    CurrencyCode = table.Column<string>(nullable: false),
                    CountryCode = table.Column<string>(nullable: false),
                    ProviderApiKey = table.Column<string>(maxLength: 512, nullable: false),
                    ProviderUri = table.Column<string>(maxLength: 512, nullable: false),
                    Website = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    ImageUri = table.Column<string>(nullable: true),
                    ThumbnailUri = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    IsExternal = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedBy = table.Column<string>(nullable: true),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    ActivatedOn = table.Column<DateTime>(nullable: true),
                    DeactivatedOn = table.Column<DateTime>(nullable: true),
                    ActivatedBy = table.Column<string>(nullable: true),
                    DeactivatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Providers", x => x.ProviderId);
                    table.ForeignKey(
                        name: "FK_Providers_Countries_CountryCode",
                        column: x => x.CountryCode,
                        principalTable: "Countries",
                        principalColumn: "CountryCode",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Providers_Currencies_CurrencyCode",
                        column: x => x.CurrencyCode,
                        principalTable: "Currencies",
                        principalColumn: "CurrencyCode",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    SubscriptionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AccountSubscription = table.Column<int>(nullable: false),
                    SubscriptionName = table.Column<string>(nullable: true),
                    SettingId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.SubscriptionId);
                    table.ForeignKey(
                        name: "FK_Subscriptions_Settings_SettingId",
                        column: x => x.SettingId,
                        principalTable: "Settings",
                        principalColumn: "SettingId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    AccountId = table.Column<string>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    CurrencyCode = table.Column<string>(nullable: false),
                    CountryCode = table.Column<string>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    ApiKey = table.Column<string>(maxLength: 512, nullable: true),
                    ApiPasswordHash = table.Column<string>(maxLength: 512, nullable: true),
                    IpnUri = table.Column<string>(maxLength: 512, nullable: false),
                    AlertEmailAddress = table.Column<string>(nullable: true),
                    AlertPhoneNumber = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    ShortDescription = table.Column<string>(nullable: true),
                    LongDescription = table.Column<string>(nullable: true),
                    SubscriptionId = table.Column<int>(nullable: false),
                    AccountSubscription = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    ApiPasswordExpiresOn = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedBy = table.Column<string>(nullable: true),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    SettingId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.AccountId);
                    table.ForeignKey(
                        name: "FK_Accounts_Countries_CountryCode",
                        column: x => x.CountryCode,
                        principalTable: "Countries",
                        principalColumn: "CountryCode",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Accounts_Currencies_CurrencyCode",
                        column: x => x.CurrencyCode,
                        principalTable: "Currencies",
                        principalColumn: "CurrencyCode",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Accounts_Settings_SettingId",
                        column: x => x.SettingId,
                        principalTable: "Settings",
                        principalColumn: "SettingId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Accounts_Subscriptions_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalTable: "Subscriptions",
                        principalColumn: "SubscriptionId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AuditLogs",
                columns: table => new
                {
                    AuditLogId = table.Column<string>(nullable: false),
                    AccountId = table.Column<string>(nullable: true),
                    LoginMetaData = table.Column<string>(nullable: true),
                    CreatedOnUTCDateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditLogs", x => x.AuditLogId);
                    table.ForeignKey(
                        name: "FK_AuditLogs_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    TransactionId = table.Column<string>(nullable: false),
                    BatchId = table.Column<string>(nullable: true),
                    AccountId = table.Column<string>(nullable: false),
                    RequestId = table.Column<string>(nullable: false),
                    CustomerId = table.Column<string>(maxLength: 255, nullable: true),
                    CurrencyCode = table.Column<string>(nullable: false),
                    CountryCode = table.Column<string>(nullable: false),
                    ProviderId = table.Column<string>(nullable: false),
                    ProductId = table.Column<string>(nullable: false),
                    ChannelId = table.Column<string>(nullable: false),
                    Channel = table.Column<int>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    Value = table.Column<decimal>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    TransactionStartTime = table.Column<DateTime>(nullable: false),
                    Memo = table.Column<string>(maxLength: 512, nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    StatusMessage = table.Column<string>(nullable: false),
                    TransactionEndTime = table.Column<DateTime>(nullable: true),
                    OrderReference = table.Column<string>(nullable: false),
                    PaymentReference = table.Column<string>(nullable: false),
                    RequestReference = table.Column<string>(nullable: false),
                    Metadata = table.Column<string>(nullable: true),
                    ChannelReference = table.Column<string>(nullable: true),
                    PaymentStartTime = table.Column<DateTime>(nullable: true),
                    PaymentId = table.Column<string>(maxLength: 255, nullable: true),
                    PaymentStatus = table.Column<int>(nullable: false),
                    PaymentStatusCode = table.Column<int>(nullable: false),
                    PaymentStatusMessage = table.Column<string>(nullable: true),
                    PaymentEndTime = table.Column<DateTime>(nullable: true),
                    OrderStartTime = table.Column<DateTime>(nullable: true),
                    OrderId = table.Column<string>(maxLength: 255, nullable: true),
                    OrderStatus = table.Column<int>(nullable: false),
                    OrderStatusCode = table.Column<int>(nullable: false),
                    OrderStatusMessage = table.Column<string>(nullable: true),
                    OrderEndTime = table.Column<DateTime>(nullable: true),
                    CommitStartTime = table.Column<DateTime>(nullable: true),
                    CommitId = table.Column<string>(maxLength: 255, nullable: true),
                    CommitStatus = table.Column<int>(nullable: false),
                    CommitStatusCode = table.Column<int>(nullable: false),
                    CommitStatusMessage = table.Column<string>(nullable: true),
                    CommitEndTime = table.Column<DateTime>(nullable: true),
                    AccountFee = table.Column<decimal>(nullable: false),
                    CustomerFee = table.Column<decimal>(nullable: false),
                    ProviderFee = table.Column<decimal>(nullable: false),
                    AccountCommission = table.Column<decimal>(nullable: false),
                    ReferralCommission = table.Column<decimal>(nullable: false),
                    ProductCommission = table.Column<decimal>(nullable: false),
                    RebateStatus = table.Column<bool>(nullable: false),
                    RebateStatusMessage = table.Column<string>(nullable: true),
                    RebateStatusCode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.TransactionId);
                    table.ForeignKey(
                        name: "FK_Transactions_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Transactions_Countries_CountryCode",
                        column: x => x.CountryCode,
                        principalTable: "Countries",
                        principalColumn: "CountryCode",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Transactions_Currencies_CurrencyCode",
                        column: x => x.CurrencyCode,
                        principalTable: "Currencies",
                        principalColumn: "CurrencyCode",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Transactions_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Transactions_Providers_ProviderId",
                        column: x => x.ProviderId,
                        principalTable: "Providers",
                        principalColumn: "ProviderId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_CountryCode",
                table: "Accounts",
                column: "CountryCode");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_CurrencyCode",
                table: "Accounts",
                column: "CurrencyCode");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_SettingId",
                table: "Accounts",
                column: "SettingId");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_SubscriptionId",
                table: "Accounts",
                column: "SubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_AuditLogs_AccountId",
                table: "AuditLogs",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_CurrencyCode",
                table: "Countries",
                column: "CurrencyCode");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CountryCode",
                table: "Products",
                column: "CountryCode");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CurrencyCode",
                table: "Products",
                column: "CurrencyCode");

            migrationBuilder.CreateIndex(
                name: "IX_Providers_CountryCode",
                table: "Providers",
                column: "CountryCode");

            migrationBuilder.CreateIndex(
                name: "IX_Providers_CurrencyCode",
                table: "Providers",
                column: "CurrencyCode");

            migrationBuilder.CreateIndex(
                name: "IX_Settings_CurrencyCode",
                table: "Settings",
                column: "CurrencyCode");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_SettingId",
                table: "Subscriptions",
                column: "SettingId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_AccountId",
                table: "Transactions",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_CountryCode",
                table: "Transactions",
                column: "CountryCode");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_CurrencyCode",
                table: "Transactions",
                column: "CurrencyCode");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_ProductId",
                table: "Transactions",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_ProviderId",
                table: "Transactions",
                column: "ProviderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditLogs");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Providers");

            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "Currencies");
        }
    }
}
