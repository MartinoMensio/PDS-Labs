#include "StringBuffer.h"

StringBuffer::StringBuffer()
{
	bufLength = DEF_SIZE;
	buf = new char[DEF_SIZE];
	length = 0;
}

StringBuffer::StringBuffer(const char * str)
{
	int l = strlen(str);
	bufLength = (l / DEF_SIZE + 1) * DEF_SIZE;
	buf = new char[bufLength];
	strcpy(buf, str);
	length = l;
}

StringBuffer::StringBuffer(const StringBuffer & sb)
{
	bufLength = sb.bufLength;
	length = sb.length;
	buf = new char[sb.bufLength];
	strcpy(buf, sb.buf);
}

StringBuffer::~StringBuffer()
{
	delete[] buf;
}

size_t StringBuffer::size()
{
	return length;
}

size_t StringBuffer::bufsize()
{
	return bufLength;
}

void StringBuffer::clear()
{
	length = 0;
	strcpy(buf, "");
}

void StringBuffer::insert(const char * str, size_t pos)
{
	int str_l = strlen(str);
	if (length + str_l >= bufLength) {
		// need to reallocate the buffer
		int newSize = length + str_l;
		int newBufLength = (newSize / DEF_SIZE + 1) * DEF_SIZE;
		char *newBuf = new char[newBufLength];
		strcpy(newBuf, buf);
		delete[] buf;
		buf = newBuf;
		bufLength = newBufLength;
		length = strlen(buf);
	}
	if (pos > length)
	{
		// insert spaces
		for (size_t i = length; i < pos; i++)
		{
			buf[i] = ' ';
		}
		// terminate string
		buf[pos] = 0;
	}
	else {
		// move forward the chars starting from pos
		for (int i = length; i >= (signed) pos; i--)
		{
			buf[str_l + i] = buf[i];
		}
	}
	// insert string
	for (int i = 0; i < str_l; i++)
	{
		buf[i + pos] = str[i];
	}
	//buf[pos + str_l] = 0;
	// update length
	length = strlen(buf);
}

void StringBuffer::insert(const StringBuffer & sb, size_t pos)
{
	char *str = sb.buf;
	insert(str, pos);
}

void StringBuffer::append(const char * str)
{
	int pos = strlen(buf);
	insert(str, pos);
}

void StringBuffer::append(const StringBuffer & sb)
{
	char *str = sb.buf;
	append(str);
}

const char * StringBuffer::c_str()
{
	return buf;
}

void StringBuffer::set(const char * str)
{
	clear();
	append(str);
}

void StringBuffer::set(const StringBuffer & s)
{
	set(s.buf);
}
