<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="http://ec2.amazonaws.com/doc/2012-04-01/" exclude-result-prefixes="ec2">
    <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
    <xsl:variable name="ns" select="'http://ec2.amazonaws.com/doc/2012-04-01/'"/>
    <xsl:template match="ec2:DescribeReservedInstancesOfferingsResponse">
        <xsl:element name="DescribeReservedInstancesOfferingsResponse" namespace="{$ns}">
            <xsl:element name="ResponseMetadata" namespace="{$ns}">
                <xsl:element name="RequestId" namespace="{$ns}">
                    <xsl:value-of select="ec2:requestId"/>
                </xsl:element>
            </xsl:element>
            <xsl:element name="DescribeReservedInstancesOfferingsResult" namespace="{$ns}">
                <xsl:apply-templates select="ec2:reservedInstancesOfferingsSet"/>
            </xsl:element>
        </xsl:element>
    </xsl:template>

    <xsl:template match="ec2:reservedInstancesOfferingsSet">
        <xsl:for-each select="ec2:item">
            <xsl:element name="ReservedInstancesOffering" namespace="{$ns}">
                <xsl:element name="ReservedInstancesOfferingId" namespace="{$ns}">
                    <xsl:value-of select="ec2:reservedInstancesOfferingId"/>
                </xsl:element>
                <xsl:element name="InstanceType" namespace="{$ns}">
                    <xsl:value-of select="ec2:instanceType"/>
                </xsl:element>
                <xsl:element name="AvailabilityZone" namespace="{$ns}">
                    <xsl:value-of select="ec2:availabilityZone"/>
                </xsl:element>
                <xsl:element name="Duration" namespace="{$ns}">
                    <xsl:value-of select="ec2:duration"/>
                </xsl:element>
                <xsl:element name="UsagePrice" namespace="{$ns}">
                    <xsl:value-of select="ec2:usagePrice"/>
                </xsl:element>
                <xsl:element name="FixedPrice" namespace="{$ns}">
                    <xsl:value-of select="ec2:fixedPrice"/>
                </xsl:element>
                <xsl:element name="ProductDescription" namespace="{$ns}">
                    <xsl:value-of select="ec2:productDescription"/>
                </xsl:element>
                <xsl:element name="InstanceTenancy" namespace="{$ns}">
                    <xsl:value-of select="ec2:instanceTenancy"/>
                </xsl:element>
                <xsl:element name="CurrencyCode" namespace="{$ns}">
                    <xsl:value-of select="ec2:currencyCode"/>
                </xsl:element>
              <xsl:element name="OfferingType" namespace="{$ns}">
                <xsl:value-of select="ec2:offeringType"/>
              </xsl:element>

              <xsl:apply-templates select="ec2:recurringCharges"/>
            </xsl:element>
        </xsl:for-each>
    </xsl:template>

    <xsl:template match="ec2:recurringCharges">
      <xsl:for-each select="ec2:item">
        <xsl:element name="RecurringCharges" namespace="{$ns}">
          <xsl:element name="Frequency" namespace="{$ns}">
            <xsl:value-of select="ec2:frequency"/>
          </xsl:element>
          <xsl:element name="Amount" namespace="{$ns}">
            <xsl:value-of select="ec2:amount"/>
          </xsl:element>
        </xsl:element>
      </xsl:for-each>
    </xsl:template>
  
</xsl:stylesheet>
