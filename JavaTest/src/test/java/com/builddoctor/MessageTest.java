package com.builddoctor;

import com.builddoctor.Message;
import org.junit.Test;
import junit.framework.Assert;

public class MessageTest {
	@Test
	public void shouldReturnMysteronRelatedTextWhenIAskIt() {
		Message message = new Message();
		Assert.assertEquals("This is the voice of the Cybermen", message.messageText());
		
	}
}