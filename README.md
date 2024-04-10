# IBAN Validation

This project provides a solution for validating International Bank Account Numbers (IBANs) along with Business Identifier Codes (BICs), ISO 11649 RF Creditor Refernces and US Bank Routing Numbers in MICR format.

## Features

- IBAN validation: Verify the correctness of an IBAN by checking its format and performing mathematical calculations.
- Country-specific validation: Implement country-specific rules for IBAN validation, as different countries may have different requirements.
- BIC validation: Validate a BIC, confirm format, country code and length.
- RF Creditor Reference: Validate the form of a reference, confirm valid prefix, check Characters and length. 
- RF Creditor Reference: Generate a RF Creditor Reference from an existing reference.
- US Bank Routing Number: Validate a reference based on length, check Character and prefix.
- UK VAT Registration Number: Validate format and check characters. This should can be useful for checking numbers when  the HMRC API that allows for online validation is not available.
- GLN - Global location number: Validate length and check character.
