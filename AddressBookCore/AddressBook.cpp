#include "stdafx.h"
#include "AddressBook.h"
#include <cstring>
#include <iostream>
#include <fstream>
#include <string>

CAddressBook *CAddressBook::m_pInstance = NULL;

CAddressBook::CAddressBook()
	:m_pPBAddressBook(NULL)
{
}

CAddressBook::~CAddressBook()
{
	delete m_pPBAddressBook;
	m_pPBAddressBook = NULL;
}

CAddressBook *CAddressBook::Instance()
{
	if (m_pInstance == NULL)
	{
		CAddressBook *pTemp = new CAddressBook();
		pTemp->load();
		if (m_pInstance == NULL)
			m_pInstance = pTemp;
	}

	return m_pInstance;
}

std::wstring CAddressBook::getFilePath() const
{
	std::wstring strFilePath = getModulePath() + L"AddressBook.dat";
	return strFilePath;
}

void CAddressBook::save()
{
	if (m_pPBAddressBook)
	{
		std::ofstream file((LPCSTR)_tochar(getFilePath().c_str()), std::ios_base::binary);
		std::string binaryData = m_pPBAddressBook->SerializeAsString();
		file << binaryData;
		file.close();
	}
}

void CAddressBook::load()
{
	using namespace std;

	if (m_pPBAddressBook)
		delete m_pPBAddressBook;

	m_pPBAddressBook = new Abook::AddressBook();
	if (PathFileExists(getFilePath().c_str()))
	{
		ifstream file((LPCSTR)_tochar(getFilePath().c_str()), ios::binary | ios::ate);
		ifstream::pos_type pos = file.tellg();

		std::string data;
		data.resize((size_t)pos);
		file.seekg(0, ios::beg);
		file.read(&data[0], pos);

		m_pPBAddressBook->ParseFromString(data);
	}
	
}

void CAddressBook::iterateAB()
{
	if (m_pPBAddressBook)
	{
		int sz = m_pPBAddressBook->entry_size();
		for (int i = 0; i < sz; ++i)
		{
			auto entry = m_pPBAddressBook->entry(i);
			std::cout << entry.firstname() << '\t' << entry.lastname() << " ---- " << entry.address() << std::endl;
		}
	}
}

void CAddressBook::getAddresBookBinary(BYTE *ab)
{
	std::string binaryData = m_pPBAddressBook->SerializeAsString();
	std::vector<unsigned char> rawStorage;
	rawStorage.assign(binaryData.begin(), binaryData.end());

	memcpy(ab, &rawStorage[0], binaryData.size());

	//demonstration of different methods working with binary data
	if (false)
	{
		std::string protobufData;
		std::vector<unsigned char> storage;
		storage.resize(binaryData.size());
		memcpy(&storage[0], &ab[0], binaryData.size());
		protobufData.assign(storage.begin(), storage.end());

		//by parsing constructed string
		{
			Abook::AddressBook *pAB = new Abook::AddressBook();
			pAB->ParseFromString(protobufData);
			std::cout << pAB->DebugString();
		}

		//directly by parsing binary array
		{
			Abook::AddressBook *pAB = new Abook::AddressBook();
			pAB->ParseFromArray(ab, binaryData.size());
			std::cout << pAB->DebugString();
		}
	}

}

size_t CAddressBook::binarySize()
{
	std::string binaryData = m_pPBAddressBook->SerializeAsString();
	return binaryData.size();
}

void CAddressBook::addSomeRecords()
{
	if (m_pPBAddressBook)
	{
		{
			Abook::AddressBookEntry *pEntry = m_pPBAddressBook->add_entry();
			pEntry->set_id(10);
			pEntry->set_city("City 11");
			*(pEntry->mutable_address()) = "address 1";
			*(pEntry->mutable_firstname()) = "first name 1";
			*(pEntry->mutable_lastname()) = "last name 1";
		}

		{
			Abook::AddressBookEntry *pEntry = m_pPBAddressBook->add_entry();
			pEntry->set_id(11);
			*(pEntry->mutable_address()) = "address 2";
			*(pEntry->mutable_firstname()) = "first name 2";
			*(pEntry->mutable_lastname()) = "last name 2";
		}

		{
			Abook::AddressBookEntry *pEntry = m_pPBAddressBook->add_entry();
			pEntry->set_id(12);
			*(pEntry->mutable_address()) = "address 3";
			*(pEntry->mutable_firstname()) = "first name 3";
			*(pEntry->mutable_lastname()) = "last name 3";
		}

		{
			Abook::AddressBookEntry *pEntry = m_pPBAddressBook->add_entry();
			pEntry->set_id(13);
			*(pEntry->mutable_address()) = "address 4";
			*(pEntry->mutable_firstname()) = "first name 4";
			*(pEntry->mutable_lastname()) = "last name 4";
		}
	}
}